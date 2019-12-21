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
    public partial class eliminarProducto : Form
    {
        public eliminarProducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            productos objCF = new productos();
            controlProducto _cf = new controlProducto();

            objCF.Id = int.Parse(cbProducto.SelectedValue.ToString());
            _cf.eliminarProducto(objCF);
            
            label1.Text="eliminado";
          
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void eliminarProducto_Load(object sender, EventArgs e)
        {
            controlProducto _Pro = new controlProducto();
            cbProducto.DataSource = _Pro.seleccionarProductoComb();
            cbProducto.DisplayMember = "NombreProducto";
            cbProducto.ValueMember = "Id";

        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
