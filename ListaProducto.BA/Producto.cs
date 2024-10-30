using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProducto.BA
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public string UnMed { get; set; }
        public decimal Precio { get; set; }

        public Producto()
        {
            
        }
        public Producto(string codigo,
                        string descripcion,
                        string cantidad,
                        string unmed,
                        string precio)
        {
            Codigo      = codigo;
            Descripcion = descripcion;
            UnMed       = unmed;
            Cantidad    = Convert.ToDecimal(cantidad);
            Precio      = Convert.ToDecimal(precio);
        }

        public override string ToString()
        {
            string res = "";
            //res = Codigo
            //    + " " + Descripcion
            //    + " (" + UnMed
            //    + ") " + Cantidad.ToString()
            //    + " " + Precio.ToString();

            res = $" {Codigo} - {Descripcion} ({UnMed}) {Cantidad.ToString()} $ {Precio.ToString()} ";

            return res;
        }
    }
}
