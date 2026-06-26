using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase.services
{
    public class ClienteService
    {
        //private string cadenaConexion = ConfigurationManager.ConnectionStrings["opticaConnection"].ConnectionString;

        public DataTable CargarObrasSociales()
        {
            string query = "SELECT CUIT, RAZON_SOCIAL FROM OBRAS_SOCIALES";

            SqlDataAdapter da = new SqlDataAdapter(query, ClasesBase.Properties.Settings.Default.opticaConnectionString);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public void GuardarCliente(Cliente nuevoCliente)
        {
            using (SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString))
            {
                string query = @"INSERT INTO CLIENTES
                                (DNI, APELLIDO, NOMBRE, DIRECCION, NRO_CARNET, OS_CUIT)
                                VALUES
                                (@dni, @apellido, @nombre, @direccion, @carnet, @os)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@dni", nuevoCliente.Cli_DNI);
                cmd.Parameters.AddWithValue("@apellido", nuevoCliente.Cli_Apellido);
                cmd.Parameters.AddWithValue("@nombre", nuevoCliente.Cli_Nombre);
                cmd.Parameters.AddWithValue("@direccion", nuevoCliente.Cli_Direccion);
                cmd.Parameters.AddWithValue("@carnet", nuevoCliente.Cli_NroCarnet);
                cmd.Parameters.AddWithValue("@os", nuevoCliente.OS_CUIT);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable BuscarClientes(string dni, string apellido)
        {
            string query = @"SELECT *
                             FROM CLIENTES
                             WHERE DNI LIKE @dni
                             AND APELLIDO LIKE @apellido";

            SqlDataAdapter da = new SqlDataAdapter(query, ClasesBase.Properties.Settings.Default.opticaConnectionString);

            da.SelectCommand.Parameters.AddWithValue("@dni", "%" + dni + "%");
            da.SelectCommand.Parameters.AddWithValue("@apellido", "%" + apellido + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable FindByDniApellidoNombre(string dni, string apellido, string nombre, string categoria)
        {
            string cnn = ClasesBase.Properties.Settings.Default.opticaConnectionString;
            SqlDataAdapter da = new SqlDataAdapter("buscar_clientes_sp", cnn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (string.IsNullOrEmpty(dni))
                da.SelectCommand.Parameters.AddWithValue("@dni", DBNull.Value);
            else
                da.SelectCommand.Parameters.AddWithValue("@dni", dni);

            if (string.IsNullOrEmpty(apellido))
                da.SelectCommand.Parameters.AddWithValue("@apellido", DBNull.Value);
            else
                da.SelectCommand.Parameters.AddWithValue("@apellido", apellido);

            if (string.IsNullOrEmpty(nombre))
                da.SelectCommand.Parameters.AddWithValue("@nombre", DBNull.Value);
            else
                da.SelectCommand.Parameters.AddWithValue("@nombre", nombre);
            if (string.IsNullOrEmpty(categoria))
                da.SelectCommand.Parameters.AddWithValue("@categoria", "Dni");
            else
                da.SelectCommand.Parameters.AddWithValue("@categoria", categoria);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable findAllClientes()
        {
            string query = "SELECT * FROM CLIENTES";

            SqlDataAdapter da = new SqlDataAdapter(query, ClasesBase.Properties.Settings.Default.opticaConnectionString);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void ModificarCliente(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString))
            {
                string query = @"UPDATE CLIENTES
                                SET APELLIDO = @apellido,
                                    NOMBRE = @nombre,
                                    DIRECCION = @direccion,
                                    NRO_CARNET = @carnet,
                                    OS_CUIT = @os
                                WHERE DNI = @dni";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
                cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
                cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
                cmd.Parameters.AddWithValue("@carnet", cliente.Cli_NroCarnet);
                cmd.Parameters.AddWithValue("@os", cliente.OS_CUIT);
                cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarCliente(string dni)
        {
            using (SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString))
            {
                string query = "DELETE FROM CLIENTES WHERE DNI = @dni";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dni", dni);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable BuscarClientesPorObraSocial(string osCuit)
        {
            string query = @"SELECT DNI as 'DNI', APELLIDO as 'Apellido', NOMBRE as 'Nombre', DIRECCION as 'Dirección', NRO_CARNET as 'Nro Carnet', OS_CUIT as 'Obra Social'
                            FROM CLIENTES
                            WHERE OS_CUIT = @osCuit";

            SqlDataAdapter da = new SqlDataAdapter(query, ClasesBase.Properties.Settings.Default.opticaConnectionString);
            da.SelectCommand.Parameters.AddWithValue("@osCuit", osCuit);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
