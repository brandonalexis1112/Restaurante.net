using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaRestaurante.modelo
{
    class catCliente
    {
        private int id;
        private string catUser;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string CatUser
        {
            get { return catUser; }
            set { catUser = value; }
        }
    }
}
