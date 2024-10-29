using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProducto.BA
{
    public class Productos
    {
        public Producto[] Lista { get; set; } = new Producto[10];

        private int proximafila = 0;

        public void Insert(Producto producto)
        {
            Lista[proximafila] = producto;
            proximafila = proximafila + 1;
        }

        public void Update(Producto producto)
        {

        }

        public void Delete(Producto producto)
        {

        }

        public Producto Select(string codigo)
        {
            Producto pr = new Producto();

            return pr;

        }
    }
}
