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
using sistemaRestaurante.vistas;

namespace sistemaRestaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario _admin = new usuario();
            controlUsuario _cUser = new controlUsuario();

            string userr = "";
            _admin.Nombe= txtuser.Text;
            _admin.Pass = txtpass.Text;
            userr = _cUser.inicioSesion(_admin);
           
            if (txtuser.Text == userr)
            {
               
                new inicio().Show();

                this.Hide();
                

            }
            else
            {

                lbmensaje.Text = "Error";
                txtuser.Text = "";
                txtpass.Text = "";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtpass.MaxLength = 15;
          
            txtpass.PasswordChar = '*';
           
            txtpass.CharacterCasing = CharacterCasing.Lower;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new inicio().Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new productosEingredientes().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Orden().Show();
        }
    }
}
