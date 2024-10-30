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

        public bool Update(Producto producto)
        {
            bool res = false;
            int fila = BuscarFila(producto.Codigo);
            if(fila != -1)
            {
                Lista[fila] = producto;
                res = true;
            }
            return res;
        }

        public void Delete(Producto producto)
        {

        }

        public Producto Select(string codigo)
        {
            Producto pr = null;

            foreach (Producto item in Lista)
            {
                if (item != null && item.Codigo == codigo)
                {
                    pr = item;
                    break;
                }
            }

            return pr;

        }

        public int BuscarFila(string codigo)
        {
            int fila = -1;

            for (int i = 0; i < Lista.Count(); i=i+1)
            {
                if (Lista[i] != null && Lista[i].Codigo == codigo)
                {
                    fila = i;
                    break;
                }
            }
            return fila;
        }

        public override string ToString()
        {
            string res = "";

            foreach (Producto item in Lista)
            {
                if (item != null)
                {
                    res = res + item.ToString() + "\r\n";
                }
            }

            return res;
        }
    }
}
