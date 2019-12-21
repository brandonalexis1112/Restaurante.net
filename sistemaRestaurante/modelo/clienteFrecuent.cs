using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaRestaurante.modelo
{
    class clienteFrecuent
    {
        private int id;
        private string nombe;
        private string apellido;
        private string telefono;
        private string email;
        private int idDirecion;
        private int idtCliente;
        private bool respuesta=false;
       
       
      

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Nombe
        {
            get { return nombe; }
            set { nombe = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int IdDirecion
        {
            get { return idDirecion; }
            set { idDirecion = value; }
        }

        public int IdtCliente
        {
            get { return idtCliente; }
            set { idtCliente = value; }
        }



        public bool Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
    }
}
