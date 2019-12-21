using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sistemaRestaurante.modelo;
using sistemaRestaurante.controlador;

namespace sistemaRestaurante.vistas
{
    public partial class agregarProducto : Form
    {
        public agregarProducto()
        {
            InitializeComponent();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarProducto_Load(object sender, EventArgs e)
        {
            ControlCatProducto _catPro = new ControlCatProducto();
            cbCat.DataSource = _catPro.seleccionarCatProducto();
            cbCat.DisplayMember = "Categoria";
            cbCat.ValueMember = "Id";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respuestas = "";

            productos _producto = new productos();
            CatProducto cPr = new CatProducto();
            controlProducto cProdu = new controlProducto();
            _producto.NombreProducto = txtNombre.Text; 
            _producto.Descripcion = txtDes.Text;
            _producto.Precio = int.Parse(txtPrecio.Text);
            cPr.Id=int.Parse(cbCat.SelectedValue.ToString());



            _producto.Respuesta =cProdu.altaProducto(_producto,cPr);

            if (_producto.Respuesta == true)
            {
                respuestas = "Agregado Exitoso";
                label5.Text = respuestas;



            }
            else
            {
                respuestas = "Error al insertar";
                label5.Text = respuestas;
            }


            txtNombre.Text = "";
            txtDes.Text = "";
            txtPrecio.Text = "";
           
        }
    }
}
