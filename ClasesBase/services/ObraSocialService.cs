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
            obrasSociales.Add(obraSocial);
            Console.WriteLine("Numero de elementos: " + obrasSociales.Count());
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
