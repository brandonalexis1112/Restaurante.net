using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaRestaurante.modelo
{
    class direccion
    {
        private int id;
        private string numero;
        private string calle;
        private string colonia;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        public string Colonia
        {
            get { return colonia; }
            set { colonia = value; }
        }
      
    }
}
