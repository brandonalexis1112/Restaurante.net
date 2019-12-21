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
    public partial class admoningredientes : Form
    {
        public admoningredientes()
        {
            InitializeComponent();
        }

        private void ingredientes_Load(object sender, EventArgs e)
        {
            llenarGrigIngredientes();
        }
        public void llenarGrigIngredientes()
        {

            controlIngredientes _ingredientes = new controlIngredientes();

            dgwIngredientes.DataSource = _ingredientes.SelectAllIngredientes().Tables[0];
            dgwIngredientes.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingredientes _ingre = new ingredientes();
            controlIngredientes cingredientes = new controlIngredientes();
            _ingre.Ingrediente = txtIngreAdd.Text;
            _ingre.Stock = int.Parse(txtStock.Text);
            cingredientes.altaIngrediente(_ingre);
            llenarGrigIngredientes();
            txtIngreAdd.Text = "";
            txtStock.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            ingredientes objCF = new ingredientes();
         controlIngredientes _cf = new controlIngredientes();
            objCF.Ingrediente = txtNOmbredelte.Text;

            _cf.eliminarIngrediente(objCF);

            txtNOmbredelte.Text = "";
            llenarGrigIngredientes();
            
        
        }
    }
}
