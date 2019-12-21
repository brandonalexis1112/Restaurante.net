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
    public partial class detalleProductoIngredientes : Form
    {
        public detalleProductoIngredientes()
        {
            InitializeComponent();
        }

        private void detalleProductoIngredientes_Load(object sender, EventArgs e)
        {
            controlProducto _Pro = new controlProducto();
            comboBox1.DataSource = _Pro.seleccionarProductoComb();
            comboBox1.DisplayMember = "NombreProducto";
            comboBox1.ValueMember = "Id"; 
        }



        public void llenarGrig()
        {
           // textBox1.Text = comboBox1.SelectedValue.ToString();
            controlIngredientes _Cingrediente = new controlIngredientes();
            ingredientes _ingrediente = new ingredientes();
            if (comboBox1.SelectedValue.ToString() != "sistemaRestaurante.modelo.productos")
            {
                _ingrediente.Id = int.Parse(comboBox1.SelectedValue.ToString());

                dgwingredientes.DataSource = _Cingrediente.SelectIngredintesDeProducto(_ingrediente).Tables[0];
                dgwingredientes.Visible = true;
            }
            label3.Text = comboBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrig();
        }
    }
}
