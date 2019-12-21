using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaRestaurante.modelo
{
    class ingredientes
    {
        private int id;
        private string ingrediente;
        private int stock;
     

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Ingrediente
        {
            get { return ingrediente; }
            set { ingrediente = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}
