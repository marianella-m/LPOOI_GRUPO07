using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        public string Cli_DNI { get; set; }
        public string Cli_Apellido { get; set; }
        public string Cli_Nombre { get; set; }
        public string Cli_Direccion { get; set; }
        public string OS_CUIT { get; set; }
        public string Cli_NroCarnet { get; set; }

        public Cliente(string dni, string cuitObraSocial)
        {
            this.Cli_DNI = dni;
            this.OS_CUIT = cuitObraSocial;
        }

        public Cliente(string nombre, string apellido, string dni, string direccion, string cuit, string nCarnet)
        {
            this.Cli_Nombre = nombre;
            this.Cli_Apellido = apellido;
            this.Cli_DNI = dni;
            this.Cli_Direccion = direccion;
            this.OS_CUIT = cuit;
            this.Cli_NroCarnet = nCarnet;

        }
    }
}
