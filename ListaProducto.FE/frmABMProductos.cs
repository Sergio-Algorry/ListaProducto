using ListaProducto.BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaProducto.FE
{
    public partial class frmABMProductos : Form
    {
        Productos ListaProductos = new Productos();
        public frmABMProductos()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Producto pr = new Producto();
            pr.Codigo = "001";
            pr.Descripcion = "Papa";


            Producto pr2 = new Producto();
            pr2.Codigo = "002";
            pr2.Descripcion = "banana";

            ListaProductos.Lista[0] = pr;
            ListaProductos.Lista[1] = pr2;
        }
    }
}
