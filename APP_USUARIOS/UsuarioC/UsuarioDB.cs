
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioC
{
    public class UsuarioDB
    {

        #region "Declaraciones"

       Usuario usuario = new Usuario();


        #endregion


        #region "Buscar Usuario"
        public DataTable buscar_usuario(string p_usuario)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_usuarios_consultar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = p_usuario;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        #endregion


        #region "Crear Usuario"
        public string crear_usuario(Usuario p_usuario)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_usuario_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@identificacion", SqlDbType.VarChar).Value = p_usuario.identificacion;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = p_usuario.nombre_usuario;
                Comando.Parameters.Add("@login", SqlDbType.VarChar).Value = p_usuario.login_usuario;
                Comando.Parameters.Add("@password", SqlDbType.VarChar).Value = p_usuario.password_usuario;
                Comando.Parameters.Add("@estado", SqlDbType.Bit).Value = p_usuario.estado_usuario;
                Comando.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = p_usuario.fecha_nacimiento;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";

            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }




        #endregion




    }
}
