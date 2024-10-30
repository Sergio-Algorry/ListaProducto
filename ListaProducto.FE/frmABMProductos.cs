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

        //int proximafila = 0;

        public frmABMProductos()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            //Producto pr = new Producto();
            //pr.Codigo = txtCodigo.Text;
            //pr.Descripcion = txtDescripcion.Text;
            //pr.UnMed=txtUnMed.Text;
            //pr.Cantidad=Convert.ToDecimal(txtCantidad.Text);
            //pr.Precio=Convert.ToDecimal(txtPrecio.Text);
            //ListaProductos.Lista[proximafila] = pr;
            //proximafila = proximafila + 1;

            Producto pr = new Producto(txtCodigo.Text,
                                       txtDescripcion.Text,
                                       txtCantidad.Text,
                                       txtUnMed.Text,
                                       txtPrecio.Text);

            ListaProductos.Insert(pr);
            lblLista.Text = ListaProductos.ToString();
            Limpiar();


        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            Producto pr = new Producto(txtCodigo.Text,
                                       txtDescripcion.Text,
                                       txtCantidad.Text,
                                       txtUnMed.Text,
                                       txtPrecio.Text);

            bool res = ListaProductos.Update(pr);
            if (res)
            {
                lblLista.Text = ListaProductos.ToString();
            }
            else
            {
                lblLista.Text = $"El código {txtCodigo.Text} no se encontró en la lista y no se pudo actualizar";
            }
            Limpiar();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Producto pr =ListaProductos.Select(txtCodigo.Text);

            Mostrar(pr);
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtUnMed.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Focus();
        }

        private void Mostrar (Producto producto)
        {
            if (producto == null)
            {
                lblLista.Text = "El producto no se encontró";                 
            }
            else
            {
                txtCodigo.Text = producto.Codigo;
                txtDescripcion.Text = producto.Descripcion;
                txtUnMed.Text = producto.UnMed;
                txtCantidad.Text = producto.Cantidad.ToString();
                txtPrecio.Text = producto.Precio.ToString();
            }
        }
    }
}
