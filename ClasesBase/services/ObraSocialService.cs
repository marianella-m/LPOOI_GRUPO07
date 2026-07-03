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
        public ObraSocialService() { }

        /// <summary>
        /// Inserta una obra social en la base de datos.
        /// </summary>
        /// <param name="obraSocial"></param>
        public void guardar(ObraSocial obraSocial) 
        {
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

        /// <summary>
        /// Retorna las obras sociales registradas.
        /// </summary>
        /// <returns></returns>
        public DataTable obtenerTodas()
        {
            string query = "SELECT CUIT, RAZON_SOCIAL, DIRECCION, TELEFONO FROM OBRAS_SOCIALES";

            DataTable datatable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, ClasesBase.Properties.Settings.Default.opticaConnectionString);

            da.Fill(datatable);

            return datatable;
        }

        /// <summary>
        /// Retorna una obra social buscada por cuit.
        /// </summary>
        /// <returns></returns>
        public DataTable buscarPorCuit(string cuit)
        {
            string query = "SELECT CUIT, RAZON_SOCIAL, DIRECCION, TELEFONO FROM OBRAS_SOCIALES WHERE CUIT = @cuit";
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cuit", cuit);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
