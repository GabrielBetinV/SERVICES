
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioC
{
    internal class Conexion
    {

        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "USUARIOS";
            this.Servidor = "DESKTOP-EHMGOJQ";
            this.Usuario = "sa";
            this.Clave = "Domayor7";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor +
                                        "; Database=" + this.Base +
                                        "; User Id=" + this.Usuario +
                                        "; Password=" + this.Clave +
                                        ";Trust Server Certificate = true";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        } 

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
