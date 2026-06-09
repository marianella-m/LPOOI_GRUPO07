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

        public void saveObraSocial(string cuit, string razonSocial, string direccion, string telefono)
        {
            SqlConnection conection = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO OBRAS_SOCIALES (CUIT,RAZON_SOCIAL,DIRECCION,TELEFONO) VALUES (@cui,@raSo,@dir,@tel)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conection;

            cmd.Parameters.AddWithValue("@cui", cuit);
            cmd.Parameters.AddWithValue("@raSo", razonSocial);
            cmd.Parameters.AddWithValue("@dir", direccion);
            cmd.Parameters.AddWithValue("@tel", telefono);

            conection.Open();
            cmd.ExecuteNonQuery();
            conection.Close();
        }

        public static DataTable FindAllObrasSociales()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT CUIT AS [Cuit], RAZON_SOCIAL AS [Razón Social], DIRECCION AS [Dirección], TELEFONO AS [Teléfono] FROM OBRAS_SOCIALES";
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
