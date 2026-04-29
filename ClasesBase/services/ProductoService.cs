using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.services
{
    public class ProductoService
    {
        private static List<Producto> productos = new List<Producto>();

        public static void AgregarProducto(Producto p)
        {
            if (p.Prod_Precio <= 0)
            {
                throw new Exception("El precio debe ser mayor a 0");
            }

            if (BuscarPorCodigo(p.Prod_Codigo) != null)
            {
                throw new Exception("El producto ya existe");
            }

            productos.Add(p);
        }

        public static List<Producto> ObtenerProductos()
        {
            return productos;
        }

        public static Producto BuscarPorCodigo(string codigo)
        {
            foreach (Producto p in productos)
            {
                if (p.Prod_Codigo == codigo)
                {
                    return p;
                }
            }
            return null;
        }
    }
}