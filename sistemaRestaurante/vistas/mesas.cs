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
    public partial class mesas : Form
    {
        public mesas()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        int libres = 0;
        int ocupadas = 0;
        int reservadas = 0;

        public void comboDisponible(){
            controlMesa _mesa = new controlMesa();

            cbMesa.DataSource = _mesa.seleccionarMesasDispobles();
            cbMesa.DisplayMember = "NumeroMesa";
            cbMesa.ValueMember = "Id";

            cbLiberarMesas.DataSource = _mesa.seleccionarMesasOcupadas();
            cbLiberarMesas.DisplayMember = "NumeroMesa";
            cbLiberarMesas.ValueMember = "Id";
    }

        private void mesas_Load(object sender, EventArgs e)
        {

            controlClienteFrecuente _CliFr = new controlClienteFrecuente();
            
            txtCliente.AutoCompleteCustomSource = _CliFr.autocompleteCliente();
            comboDisponible();

          



            btncolor1.BackColor = Color.Lime;
            btncolor2.BackColor = Color.Red;
            btnColor3.BackColor = Color.LightPink;
            txtTotalMesas.Text = "12";
          

            pintarMesas();
            txtlibres.Text = libres + "";
            txtOcupadas.Text = ocupadas + "";
            txtReservadas.Text = reservadas + "";
          //  MessageBox.Show(arraymesas[i] +" "+ i);
          
        }


        public void pintarMesas()
        {
            string[] arraymesas = new string[12];

            controlMesa _mesa = new controlMesa();
            arraymesas = _mesa.seleccionarStatusMesa();

            //mesa 1
            if (arraymesas[0] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;
                
            }
            if (arraymesas[0] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[0] == "reservada")
            {
                m1.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 2
            if (arraymesas[1] == "libre")
            {
                m2.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[1] == "ocupada")
            {
                m2.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[1] == "reservada")
            {
                m2.BackColor = Color.LightPink;
                reservadas++;
            }


            //mesa 3
            if (arraymesas[2] == "libre")
            {
                m3.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[2] == "ocupada")
            {
                m3.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[2] == "reservada")
            {
                m3.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 4
            if (arraymesas[3] == "libre")
            {
                m4.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[3] == "ocupada")
            {
                m4.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[3] == "reservada")
            {
                m4.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 5
            if (arraymesas[4] == "libre")
            {
                m5.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[4] == "ocupada")
            {
                m5.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[4] == "reservada")
            {
                m5.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 6
            if (arraymesas[5] == "libre")
            {
                m6.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[5] == "ocupada")
            {
                m6.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[5] == "reservada")
            {
                m6.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 7
            if (arraymesas[6] == "libre")
            {
                m7.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[6] == "ocupada")
            {
                m7.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[6] == "reservada")
            {
                m7.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 8
            if (arraymesas[7] == "libre")
            {
                m8.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[7] == "ocupada")
            {
                m8.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[7] == "reservada")
            {
                m8.BackColor = Color.LightPink;
                reservadas++;
            }
            //mesa 9
            if (arraymesas[8] == "libre")
            {
                m9.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[8] == "ocupada")
            {
                m9.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[8] == "reservada")
            {
                m9.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 10
            if (arraymesas[9] == "libre")
            {
                m10.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[9] == "ocupada")
            {
                m10.BackColor = Color.Red;
                ocupadas++;

            }
            if (arraymesas[9] == "reservada")
            {
                m10.BackColor = Color.LightPink;
                reservadas++;
            }
            //mesa 11
            if (arraymesas[10] == "libre")
            {
                m11.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[10] == "ocupada")
            {
                m11.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[10] == "reservada")
            {
                m11.BackColor = Color.LightPink;
                reservadas++;
            }

          //  mesa 12
            if (arraymesas[11] == "libre")
            {
                m12.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[11] == "ocupada")
            {
                m12.BackColor = Color.Red;
                ocupadas++;

            }
            if (arraymesas[11] == "reservada")
            {
                m12.BackColor = Color.LightPink;
                reservadas++;
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            mcc2.Visible = true;
            x1.Visible = true;
        }

        private void x1_Click(object sender, EventArgs e)
        {
            mcc2.Visible = false;
            x1.Visible = false;
        }

        private void mcc2_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaReservacion.Text = mcc2.SelectionStart.ToString(); 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void m11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            libres = 0;
            ocupadas = 0;
            reservadas = 0;
            string respuestas = "";

            mesa _mesa = new mesa();
            clienteFrecuent _clF = new clienteFrecuent();
           controlMesa cm=new controlMesa();
           

            _mesa.Id = int.Parse(cbMesa.SelectedValue.ToString()); 
            _clF.Nombe = txtCliente.Text;



            _clF.Respuesta = cm.ReservarMesa(_mesa, txtFechaReservacion.Text, _clF);
            pintarMesas();
            if (_clF.Respuesta == true)
            {
                respuestas = "Reservacion exitosa";
                label4.Text = respuestas;

                
                
            }
            else
            {
                respuestas = "Error al reservar";
                label4.Text = respuestas;
            }

            txtFechaReservacion.Text = "";
            txtCliente.Text = "";
            comboDisponible();
            txtlibres.Text = libres + "";
            txtOcupadas.Text = ocupadas + "";
            txtReservadas.Text = reservadas + "";
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            libres = 0;
            ocupadas = 0;
            reservadas = 0;
            mesa _mesa = new mesa();
      
            controlMesa cm = new controlMesa();


            _mesa.Id = int.Parse(cbLiberarMesas.SelectedValue.ToString());
         
            cm.liberarMesa(_mesa);
            pintarMesas();
            comboDisponible();
            txtlibres.Text = libres + "";
            txtOcupadas.Text = ocupadas + "";
            txtReservadas.Text = reservadas + "";
            pnlLiberar.Visible = false;
        }

        private void liberarMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLiberar.Visible = true;
        }
    }
}
