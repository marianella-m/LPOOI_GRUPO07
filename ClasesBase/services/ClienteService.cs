using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.services
{
    public class ClienteService
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static void AgregarCliente(Cliente p)
        {

            if (BuscarPordni(p.Cli_DNI) != null)
            {
                throw new Exception("El Cliente ya existe");
            }

            clientes.Add(p);
        }

        public static List<Cliente> Obtenerclientes()
        {
            return clientes;
        }

        public static Cliente BuscarPordni(string dni)
        {
            foreach (Cliente p in clientes)
            {
                if (p.Cli_DNI == dni)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
