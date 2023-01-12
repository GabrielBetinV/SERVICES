using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WS_Usuarios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetUsuario(string identificacion);

        //[OperationContract]
        //Usuarios PostUsuario(Usuarios usuario);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Usuarios
    {
        int identificacion_usuario;
        string nombre_usuario;
        string login_usuario;
        string password_usuario;
        bool estado_activo = true;
        DateTime fecha_nacimiento;


        [DataMember]
        public int Identificacion_usuario
        {
            get { return identificacion_usuario; }
            set { identificacion_usuario = value; }
        }


        [DataMember]
        public bool Estado_activo
        {
            get { return estado_activo; }
            set { estado_activo = value; }
        }

        [DataMember]
        public string Nombre_usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }

        [DataMember]
        public string Login_usuario
        {
            get { return login_usuario; }
            set { login_usuario = value; }
        }


        [DataMember]
        public string Password_usuario
        {
            get { return password_usuario; }
            set { password_usuario = value; }
        }

        [DataMember]
        public DateTime Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }



    }
}
