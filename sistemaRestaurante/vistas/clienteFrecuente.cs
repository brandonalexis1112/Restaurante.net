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
    public partial class clienteFrecuente : Form
    {
        public clienteFrecuente()
        {
            InitializeComponent();
        }

        private void clienteFrecuente_Load(object sender, EventArgs e)
        { 
            controllercatCliente _Cliente = new controllercatCliente();
            cbCategoria.DataSource = _Cliente.seleccionarCatCliente();
            cbCategoria.DisplayMember = "CatUser";
            cbCategoria.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          

            direccion _us = new direccion();
            controlDireccion cDirec = new controlDireccion();
            _us.Numero = txtNumer.Text;
            _us.Calle = txtCalle.Text;
            _us.Colonia= txtColonia.Text;
            cDirec.altaDireccion(_us);
            controlClienteFrecuente _cf = new controlClienteFrecuente();
            clienteFrecuent _mcf = new clienteFrecuent();
            _mcf.Nombe= txtNombre.Text;
            _mcf.Apellido = txtApellido.Text;
            _mcf.Telefono = txtTelefono.Text;
            _mcf.Email = txtEmail.Text;
            _mcf.IdtCliente = int.Parse(cbCategoria.SelectedValue.ToString());
            _cf.altaClienteFrecuente(_mcf);
            

           


          
        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
