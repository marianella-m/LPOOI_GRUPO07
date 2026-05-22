using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase.services
{
    public class VentaService{

        //public static List<Venta> FindAllVentas()

        public static DataTable FindAllVentas()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT NUMERO, FECHA, CLI_DNI FROM VENTAS";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable datatable = new DataTable();
            datatable.Load(reader, LoadOption.OverwriteChanges);

            connection.Close();
            return datatable;
        }


        public static void InsertVenta(Venta venta)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            string queryInsertVenta = "INSERT INTO VENTAS (CLI_DNI, FECHA) VALUES (@Dni, @Fecha); SELECT SCOPE_IDENTITY();" ;
            int idVentaGenerado;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = queryInsertVenta;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@Dni", venta.Cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);

            connection.Open();
            idVentaGenerado = Convert.ToInt32(cmd.ExecuteScalar());

            InsertDetalles(cmd, venta.detalles, idVentaGenerado);

            //connection.Close();
        }

        static void InsertDetalles(SqlCommand cmd, List<VentaDetalle> detalles, int ventaNumero)
        {
            string queryInsertDetalles = @"INSERT INTO VENTAS_DETALLES (VENTA_NUMERO, PRO_CODIGO, PRECIO, CANTIDAD, TOTAL) 
                                           VALUES (@VentaNumero, @ProductoCodigo, @ProductoPrecio, @Cantidad, (@Cantidad * @ProductoPrecio));";

            cmd.CommandText = queryInsertDetalles;

            cmd.Parameters.Add("@VentaNumero", SqlDbType.Int);
            cmd.Parameters.Add("@ProductoCodigo", SqlDbType.VarChar);
            cmd.Parameters.Add("@ProductoPrecio", SqlDbType.Decimal);
            cmd.Parameters.Add("@Cantidad", SqlDbType.Decimal); 

            foreach(VentaDetalle detalle in detalles)
            {
                cmd.Parameters["@VentaNumero"].Value = ventaNumero;
                cmd.Parameters["@ProductoCodigo"].Value = detalle.Producto.Prod_Codigo;
                cmd.Parameters["@ProductoPrecio"].Value = detalle.Producto.Prod_Precio;
                cmd.Parameters["@Cantidad"].Value = detalle.Cantidad;
                cmd.ExecuteNonQuery();
            }

            cmd.Connection.Close();
        }
    }
}
