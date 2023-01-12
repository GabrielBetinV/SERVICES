using System.Data;
using UsuarioC;

namespace Usuarios
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {


            if (tb_usuario.Text == String.Empty || tb_contraseña.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {

                UsuarioDB inicio_sesion = new UsuarioDB();

                DataTable table = new DataTable();
                table = inicio_sesion.buscar_usuario(tb_usuario.Text);


                if (table.Rows.Count > 0)
                {


                    if (table.Rows[0][2].ToString().Trim() == tb_usuario.Text.ToUpper())
                    {

                        if (table.Rows[0][3].ToString().Trim() == tb_contraseña.Text.ToUpper())
                        {


                            UsuarioWS.identificacionBD = table.Rows[0][0].ToString().Trim();
                            UsuarioWS.nombre_usuarioBDd = table.Rows[0][1].ToString().Trim();
                            UsuarioWS.login_usuarioBD = table.Rows[0][2].ToString().Trim();
                            UsuarioWS.password_usuarioBD = table.Rows[0][3].ToString().Trim();
                            UsuarioWS.estado_usuarioBD = Convert.ToBoolean(table.Rows[0][4].ToString().Trim());
                            UsuarioWS.fecha_nacimientoBD = (DateTime)table.Rows[0][5];

                            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                            ServiceReference1.GetUsuarioRequest request = new ServiceReference1.GetUsuarioRequest { identificacion = UsuarioWS.identificacionBD };
                            ServiceReference1.GetUsuarioResponse response = new ServiceReference1.GetUsuarioResponse();
                            response = client.GetUsuario(request);


                            string[] texto = response.GetUsuarioResult.ToString().Split(",");


                            UsuarioWS.nombre_usuarioWS = texto[0];
                            UsuarioWS.estado_usuarioWS = Convert.ToBoolean(texto[1]);
                            UsuarioWS.edad_usuarioWS = texto[2];


                            MessageBox.Show(response.GetUsuarioResult.ToString());


                            MessageBox.Show(String.Format("Bienvenido a nuestro sistemas {0}", texto[0].ToString()),
                                             "Acceso concedido",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);

                            frm_usuarioWS frm = new frm_usuarioWS();
                            frm.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Contraseña errada, validar informacion", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario errado, validar informacion", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
                else
                {


                    MessageBox.Show("Usuario errado, validar informacion", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }













        }

        private void bt_registrar_Click(object sender, EventArgs e)
        {
            frm_usuario frm = new frm_usuario();
            frm.ShowDialog();

        }
    }
}