using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase.services
{
    public class LoginService
    {

        public static Usuario loginLista(List<Usuario> usuarios, string username, string password) {
            Usuario userSearch = usuarios.FirstOrDefault(
                usu => 
                    username.Equals(usu.Usu_NombreUsuario) &&
                    password.Equals(usu.Usu_Password )
                    );

            return userSearch;
        
        }
        public static Usuario loginDB(string usuario, string pass)
        {
            Usuario u = null;

            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"
                SELECT U.*, R.Rol_Descripcion
                FROM Usuarios U
                INNER JOIN Roles R
                ON U.Rol_Codigo = R.Rol_Codigo
                WHERE Usu_NombreUsuario=@usuario
                AND Usu_Contraseña=@pass";

            cmd.CommandType = CommandType.Text;

            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@usuario", usuario);

            cmd.Parameters.AddWithValue("@pass", pass);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string nom = reader["Usu_NombreUsuario"].ToString();
                string password = reader["Usu_Contraseña"].ToString();
                string ape = reader["Usu_ApellidoNombre"].ToString();
                int rol = Convert.ToInt32(reader["Rol_Codigo"]);
                u = new Usuario(nom, password, ape, rol);
            }
            con.Close();

            return u;
        }
    }
}
