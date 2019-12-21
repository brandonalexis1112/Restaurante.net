using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace sistemaRestaurante.baseDatos
{
    class conexion
    {
        private String cadenaConexionBaseDeDatos;
        public String obtenerCadenaDeConexion()
        {
            //aqui se encuentra la cadena de conexion  modique en segun el sql de su maquina
            cadenaConexionBaseDeDatos = "Data Source=201-26;Initial Catalog=restaurante;Persist Security Info=True;User ID=sa;Password=123456";
            return cadenaConexionBaseDeDatos;
        }


        ///////
        private SqlConnection conexionBaseDatos;
        public conexion()
        {
            conexionBaseDatos = new SqlConnection(obtenerCadenaDeConexion());
        }

          public SqlConnection openDataBase()
        {
            conexionBaseDatos.Open();
            if (conexionBaseDatos == null)
            {
                conexionBaseDatos.Close();
            }
            return conexionBaseDatos;
        }

       
        public void closeDatabase()
        {
            try
            {
                conexionBaseDatos.Close();
            }
            catch (Exception _ex)
            {
                String mnsaje = _ex.Message;
            }
        }



    }
}
