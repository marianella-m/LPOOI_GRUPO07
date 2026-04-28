using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Rol
    {
        public int Rol_Codigo {get; set;}
        public string Rol_Descripcion { get; set; }

        public Rol(int Rol_Codigo, string Rol_Descripcion)
        {
            this.Rol_Codigo = Rol_Codigo;
            this.Rol_Descripcion = Rol_Descripcion;
        }
    }
}
