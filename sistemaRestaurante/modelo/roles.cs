using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaRestaurante.modelo
{
    class roles
    {
        private int id;
        private string roluser;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Roluser
        {
            get { return roluser; }
            set { roluser = value; }
        }
    }
}
