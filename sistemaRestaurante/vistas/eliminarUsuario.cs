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
    public partial class eliminarUsuario : Form
    {
        public eliminarUsuario()
        {
            InitializeComponent();
        }

        private void btneleiminar_Click(object sender, EventArgs e)
        {
            string respuestas = "";

            usuario objUsuario = new usuario();
            controlUsuario cUsua= new controlUsuario();


            
          
            objUsuario.Nombe = txtNombre.Text;


            objUsuario.Respuesta = cUsua.eliminarUsuario(objUsuario);

            if (objUsuario.Respuesta == true)
            {
                respuestas = "Eliminacion Completa";
                label2.Text = respuestas;



            }
            else
            {
                respuestas = "Eliminacion Completa";
                label2.Text = respuestas;
            }


            txtNombre.Text = "";
        }

        private void eliminarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
