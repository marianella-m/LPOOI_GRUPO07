using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase.services
{
    public class ClienteService
    {
        private string cadenaConexion =
            ConfigurationManager.ConnectionStrings["opticaConnection"].ConnectionString;

        public DataTable CargarObrasSociales()
        {
            string query = "SELECT CUIT, RAZON_SOCIAL FROM OBRAS_SOCIALES";

            SqlDataAdapter da = new SqlDataAdapter(query, cadenaConexion);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public void GuardarCliente(string dni, string apellido, string nombre,
                                   string direccion, string nroCarnet, string osCuit)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = @"INSERT INTO CLIENTES
                                (DNI, APELLIDO, NOMBRE, DIRECCION, NRO_CARNET, OS_CUIT)
                                VALUES
                                (@dni, @apellido, @nombre, @direccion, @carnet, @os)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@carnet", nroCarnet);
                cmd.Parameters.AddWithValue("@os", osCuit);

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

            SqlDataAdapter da = new SqlDataAdapter(query, cadenaConexion);

            da.SelectCommand.Parameters.AddWithValue("@dni", "%" + dni + "%");
            da.SelectCommand.Parameters.AddWithValue("@apellido", "%" + apellido + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void ModificarCliente(string dni, string apellido, string nombre,
                                     string direccion, string nroCarnet, string osCuit)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = @"UPDATE CLIENTES
                                SET APELLIDO = @apellido,
                                    NOMBRE = @nombre,
                                    DIRECCION = @direccion,
                                    NRO_CARNET = @carnet,
                                    OS_CUIT = @os
                                WHERE DNI = @dni";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@carnet", nroCarnet);
                cmd.Parameters.AddWithValue("@os", osCuit);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCliente(string dni)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM CLIENTES WHERE DNI = @dni";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dni", dni);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
