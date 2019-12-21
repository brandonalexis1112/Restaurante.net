using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sistemaRestaurante.controlador;
using sistemaRestaurante.modelo;

namespace sistemaRestaurante.vistas
{
    public partial class tipoOrden : Form
    {
        public tipoOrden()
        {
            InitializeComponent();
        }

        private void tipoOrden_Load(object sender, EventArgs e)
        {
            controlUsuario user= new controlUsuario();
            controlClienteFrecuente clie = new controlClienteFrecuente();


            cbresponsable.DataSource = user.seleccionarUsuarios();
            cbresponsable.DisplayMember = "Nombe";
            cbresponsable.ValueMember = "Id";

            cbAtendio.DataSource = user.seleccionarUsuarios();
            cbAtendio.DisplayMember = "Nombe";
            cbAtendio.ValueMember = "Id";


            controlMesa _mesa = new controlMesa();

            cbMesa.DataSource = _mesa.seleccionarMesasDispobles();
            cbMesa.DisplayMember = "NumeroMesa";
            cbMesa.ValueMember = "Id";

            cbCliente.DataSource = clie.seleccionarCliente();
            cbCliente.DisplayMember = "Nombe";
            cbCliente.ValueMember = "Id";


            cbcliebtellevar.DataSource = clie.seleccionarCliente();
            cbcliebtellevar.DisplayMember = "Nombe";
            cbcliebtellevar.ValueMember = "Id"; 
            
        }

        private void btlOpcion1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
        }

        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel1.Enabled = false;
           
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
          

            mesa _mesa = new mesa();
            clienteFrecuent _clF = new clienteFrecuent();
            usuario _usuario = new usuario();
            controlOrden _controlOrden = new controlOrden();
            _mesa.Id = int.Parse(cbMesa.SelectedValue.ToString());
            _clF.Id = int.Parse(cbCliente.SelectedValue.ToString());
            _usuario.Id = int.Parse(cbresponsable.SelectedValue.ToString());


            _clF.Respuesta = _controlOrden.altaOrdenTipoMesaLocal(_mesa, _clF, _usuario);
            if (_clF.Respuesta == true)
            {
                lblRespuesta.Text = "La orden Se ha registrado";
            }
            else
            {
                lblRespuesta.Text = "Erroe al registrar la orden";
            }
            panel1.Enabled = false;
            btlOpcion1.Enabled = false;
            btnOpcion2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            clienteFrecuent _clF = new clienteFrecuent();
            usuario _usuario = new usuario();
            controlOrden _controlOrden = new controlOrden();

            _clF.Id = int.Parse(cbcliebtellevar.SelectedValue.ToString());
            _usuario.Id = int.Parse(cbAtendio.SelectedValue.ToString());
             

            _clF.Respuesta = _controlOrden.altaOrdenParaLlevar(txtDescricion.Text, _clF, _usuario);
            if (_clF.Respuesta == true)
            {
                lblRespuesta.Text = "La orden Se ha registrado";
            }
            else
            {
                lblRespuesta.Text = "Erroe al registrar la orden";
            }

            panel2.Enabled = false;
            btnOpcion2.Enabled = false;
            btlOpcion1.Enabled = false;
        }
    }
}
