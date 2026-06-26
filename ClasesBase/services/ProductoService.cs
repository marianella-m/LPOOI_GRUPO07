using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase.services
{
    public class ProductoService
    {
        public static DataTable list_productos()
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CODIGO as 'Código', CATEGORIA as 'Categoría', DESCRIPCION as 'Descripción', PRECIO as 'Precio' FROM PRODUCTOS";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static DataTable search_productos(string pattern)
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CODIGO as 'Código', CATEGORIA as 'Categoría', DESCRIPCION as 'Descripción', PRECIO as 'Precio' FROM PRODUCTOS WHERE DESCRIPCION LIKE @pattern OR DESCRIPCION LIKE @pattern";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@pattern", "%" + pattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static Producto buscarPorCodigo(string codigo)
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM PRODUCTOS WHERE CODIGO=@cod";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@cod", codigo);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Producto p = new Producto(
                    reader["CODIGO"].ToString(),
                    reader["CATEGORIA"].ToString(),
                    reader["DESCRIPCION"].ToString(),
                    Convert.ToDecimal(reader["PRECIO"])
                );

                con.Close();
                return p;
            }

            con.Close();
            return null;
        }
        public static void insert_producto(string codigo, string categoria, string descripcion, decimal precio)
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insertar_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@cod", codigo);
            cmd.Parameters.AddWithValue("@cat", categoria);
            cmd.Parameters.AddWithValue("@des", descripcion);
            cmd.Parameters.AddWithValue("@pre", precio);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void update_producto(string codigo, string categoria, string descripcion, decimal precio)
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "actualizar_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@cod", codigo);
            cmd.Parameters.AddWithValue("@cat", categoria);
            cmd.Parameters.AddWithValue("@des", descripcion);
            cmd.Parameters.AddWithValue("@pre", precio);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void delete_producto(string codigo)
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminar_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@cod", codigo);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable list_productos_por_descripcion_sp()
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "dbo.listar_productos_por_descripcion_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_productos_por_categoria_sp()
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "dbo.listar_productos_por_categoria_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_productos_por_cliente_sp(string dni)
        {
            DataTable dt = new DataTable();

            string cnn = ClasesBase.Properties.Settings.Default.opticaConnectionString;

            using (SqlConnection connection = new SqlConnection(cnn))
            {
                SqlCommand cmd = new SqlCommand("listar_productos_por_cliente_sp", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", dni);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public static DataTable listar_productos_por_fecha_sp(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos_por_fecha_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                cnn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return dt;

        }

    
    }
}



/*
 
 // 1. Declaramos la variable al principio
    DataTable dt = new DataTable();

    try
    {
        // Usa la cadena o método de conexión que ya tengas en tu proyecto (ej. Conexion.ObtenerConexion())
        using (SqlConnection conexion = new SqlConnection("Tu_Cadena_Conexion_Aqui")) 
        {
            using (SqlCommand cmd = new SqlCommand("dbo.listar_productos_por_fecha_sp", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    conexion.Open();
                    da.Fill(dt); // Si todo sale bien, se llena aquí
                }
            }
        }
    }
 
 
 */