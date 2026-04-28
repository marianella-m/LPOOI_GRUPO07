using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
       public int Usu_ID {get; set; }
       public string Usu_NombreUsuario {get; set; }
       public string Usu_Password {get; set; }
       public string Usu_ApellidoNombre {get; set; }
       public int Rol_Codigo { get; set; }


        public Usuario(string Usu_NombreUsuario, string Usu_Password, string Usu_ApellidoNombre, int Rol_Codigo)
        {
            this.Usu_NombreUsuario = Usu_NombreUsuario;
            this.Usu_Password = Usu_Password;
            this.Usu_ApellidoNombre = Usu_ApellidoNombre;
            this.Rol_Codigo = Rol_Codigo;
        }
    }
}
