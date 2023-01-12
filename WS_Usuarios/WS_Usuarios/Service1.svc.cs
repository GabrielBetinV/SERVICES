using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;

namespace WS_Usuarios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetUsuario(string identificacion)
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_usuarios_consultar_ws", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@identificacion_usuario ", SqlDbType.VarChar).Value = identificacion;
                SqlCon.Open();

                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);

                return Tabla.Rows[0][0].ToString() + "," + Tabla.Rows[0][1].ToString() + "," + Tabla.Rows[0][2].ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }



            return "";
        }

        //public Usuarios PostUsuario(Usuarios usuario)
        //{

        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        SqlCon = Conexion.getInstancia().CrearConexion();
        //        SqlCommand Comando = new SqlCommand("sp_usuario_actualizar", SqlCon);
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.Nombre_usuario;
        //        Comando.Parameters.Add("@login", SqlDbType.VarChar).Value = usuario.Login_usuario;
        //        Comando.Parameters.Add("@password", SqlDbType.VarChar).Value = usuario.Password_usuario;
        //        Comando.Parameters.Add("@estado", SqlDbType.Bit).Value = usuario.Estado_activo;
        //        Comando.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = usuario.Fecha_nacimiento;
        //        SqlCon.Open();
               
        //        return usuario;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //    }



        //    return usuario;
        //}
    }
}
