using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
