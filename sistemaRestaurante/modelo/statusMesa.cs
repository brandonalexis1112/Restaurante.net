using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaRestaurante.modelo
{
    class statusMesa
    {
        private int id;
        
        private string descripcion;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descripcion
        {
            get { return descripcion ; }
            set { descripcion = value; }
        }
        
    }
}
