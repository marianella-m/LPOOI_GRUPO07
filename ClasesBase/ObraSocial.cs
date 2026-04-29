using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ObraSocial
    {
      public string OS_CUIT { get; set; }
      public string OS_RazonSocial { get; set; }
      public string OS_Direccion { get; set; }
      public string OS_Telefono { get; set; }


      public ObraSocial(string cuit, string razonSocial, string direccion, string telefono) {
          this.OS_CUIT = cuit;
          this.OS_RazonSocial = razonSocial;
          this.OS_Direccion = direccion;
          this.OS_Telefono = telefono;
      }

    }
}
