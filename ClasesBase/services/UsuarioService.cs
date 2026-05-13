using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClasesBase.services
{
    public class UsuarioService
    {
        public static DataTable list_roles(){
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ROLES";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void insert_usuario(Usuario user){
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO USUARIOS(Usu_NombreUsuario,Usu_Contraseña,Usu_ApellidoNombre,Rol_Codigo) values(@nom,@pass,@ape,@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@ape", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Password);
            cmd.Parameters.AddWithValue("@nom", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable list_usuarios()
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Rol_Descripcion as 'Rol', ";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario', ";
            cmd.CommandText += " Usu_Contraseña as 'Password', ";
            cmd.CommandText += " Usu_ApellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += " Usu_ID as 'ID' , U.Rol_Codigo as 'ROL_ID' ";
            cmd.CommandText += " FROM Usuarios as U ";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Rol_Codigo=U.Rol_Codigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable search_usuarios(string sPattern)
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Rol_Descripcion as 'Rol', ";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario', ";
            cmd.CommandText += " Usu_Contraseña as 'Password', ";
            cmd.CommandText += " Usu_ApellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += " Usu_ID as 'ID' , U.Rol_Codigo as 'ROL_ID' ";
            cmd.CommandText += " FROM Usuarios as U ";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Rol_Codigo=U.Rol_Codigo)";
            cmd.CommandText += " WHERE";
            cmd.CommandText += " Usu_NombreUsuario LIKE @pattern ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@pattern", "%"+sPattern+"%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static Usuario buscarPorId(int id){
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM Usuarios WHERE Usu_ID = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string nom = reader["Usu_NombreUsuario"].ToString();
                string pass = reader["Usu_Contraseña"].ToString();
                string ape = reader["Usu_ApellidoNombre"].ToString();
                int rol = Convert.ToInt32(reader["Rol_Codigo"]);
                Usuario usuario = new Usuario(nom, pass, ape, rol);
                return usuario;
            }
            else
                return null;
        }

        public static void update_usuario(Usuario usuario){
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Usuarios SET Usu_NombreUsuario=@usuario, Usu_Contraseña=@pass, Rol_Codigo=@rol WHERE Usu_ID=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@usuario", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", usuario.Usu_Password);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);
            cmd.Parameters.AddWithValue("@id", usuario.Usu_ID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void delete_usuarios(int id){
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuarios WHERE Usu_ID=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
