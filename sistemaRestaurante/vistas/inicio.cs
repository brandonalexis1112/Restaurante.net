using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaRestaurante.vistas
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
        private void inicio_Load(object sender, EventArgs e)
        {
       
   
           
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new altaUsuario().Show();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new eliminarUsuario().Show();
        }

        private void agragarClienteFrecuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new clienteFrecuente().Show();
        }

        private void eliminarClienteFrecuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new eliminarClienteFrecu().Show();
        }

        private void distribucionDeLasMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new mesas().Show();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Orden().Show(); ;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new productosEingredientes().Show();
        }

        private void almacenDeIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new admoningredientes().Show();
        }
    }
}
