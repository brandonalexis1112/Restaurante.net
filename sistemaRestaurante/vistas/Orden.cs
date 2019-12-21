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
    public partial class Orden : Form
    {
        public Orden()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void cargarGrigOrden()
        {
        


        

            dgwOrden.ColumnCount = 4;
            dgwOrden.Columns[0].Name = "Nombre";
            dgwOrden.Columns[1].Name = "Descripcion";
            dgwOrden.Columns[2].Name = "$Precio";
            dgwOrden.Columns[3].Name = "Categoria Producto";
      
           
           
        }


        private void Orden_Load(object sender, EventArgs e)
        {
            cargarGrigOrden();
            ControlCatProducto _catPro = new ControlCatProducto();
            cbCategoria.DataSource = _catPro.seleccionarCatProducto();
            cbCategoria.DisplayMember = "Categoria";
            cbCategoria.ValueMember = "Id";
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrig();
          //  textBox1.Text = cbCategoria.SelectedValue.ToString();
            
        }

        public void llenarGrig()
        {
            controlProducto _Cproducto = new controlProducto();
            CatProducto _categoriaproducto = new CatProducto();
            if (cbCategoria.SelectedValue.ToString() != "sistemaRestaurante.modelo.CatProducto")
            {
             _categoriaproducto.Id = int.Parse(cbCategoria.SelectedValue.ToString());

                dgwMenu.DataSource = _Cproducto.SelectProductoByCattegoria(_categoriaproducto).Tables[0];
                dgwMenu.Visible = true;
            }
        }

        private void dgwMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            




            string fila1 = Convert.ToString(dgwMenu.CurrentRow.Cells[0].Value);
            string fila2 = Convert.ToString(dgwMenu.CurrentRow.Cells[1].Value);
            string fila3 = Convert.ToString(dgwMenu.CurrentRow.Cells[2].Value);
            string fila4 = Convert.ToString(dgwMenu.CurrentRow.Cells[3].Value);
            

            
         //  int subtotal = int.Parse(fila3) * int.Parse(txtcantidad.Text);

            string[] row = new string[] { fila1, fila2, fila3, fila4 };
            dgwOrden.Rows.Add(row);


            
            int sumatoria = 0;
            foreach (DataGridViewRow rows in dgwOrden.Rows)
            {
                sumatoria +=  Convert.ToInt32(rows.Cells[2].Value);


            }

            txtTotalOrden.Text = Convert.ToString(sumatoria);



        }

        private void button1_Click(object sender, EventArgs e)
        {
          



            controlOrden _venta = new controlOrden();

            _venta.altaOrden(int.Parse(txtTotalOrden.Text));






            foreach (DataGridViewRow rowss in dgwOrden.Rows)
            {
                
                string c = Convert.ToString(rowss.Cells[0].Value);
         
                // MessageBox.Show(colu + "");
                if (c != "")
                {
                    _venta.altaDetelleOrden(c);
                }
            }
           
         new tipoOrden().Show();

         this.Hide(); 
        }
    }
}
