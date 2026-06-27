using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase.services
{
    public class ObraSocialService
    {
        List<ObraSocial> obrasSociales = new List<ObraSocial>();

        public ObraSocialService() { }

        public void saveObraSocial(ObraSocial obraSocial) {
            string connectionString = ClasesBase.Properties.Settings.Default.opticaConnectionString;

            string query = "INSERT INTO OBRAS_SOCIALES (CUIT, RAZON_SOCIAL, DIRECCION, TELEFONO) VALUES (@cuit, @razon, @dir, @tel)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cuit", obraSocial.OS_CUIT); 
                    cmd.Parameters.AddWithValue("@razon", obraSocial.OS_RazonSocial);
                    cmd.Parameters.AddWithValue("@dir", obraSocial.OS_Direccion);
                    cmd.Parameters.AddWithValue("@tel", obraSocial.OS_Telefono);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static DataTable FindAllObrasSociales()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT CUIT AS [Cuit], RAZON_SOCIAL AS [Razón Social], DIRECCION AS [Dirección], TELEFONO AS [Teléfono] FROM VENTAS";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable datatable = new DataTable();
            datatable.Load(reader, LoadOption.OverwriteChanges);

            connection.Close();
            return datatable;
        }
    }
}
