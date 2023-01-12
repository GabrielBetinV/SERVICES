
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioC;

namespace Usuarios
{
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
        }

        private void pb_guardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (tb_nombre.Text == String.Empty || tb_login.Text == String.Empty ||
                    tb_password.Text == String.Empty || tb_identificacion.Text == String.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Rpta = "";

                    Usuario usuario = new Usuario()
                    {
                        identificacion = tb_identificacion.Text.Trim().ToUpper(),
                        nombre_usuario =  tb_nombre.Text.Trim().ToUpper(),
                        login_usuario = tb_login.Text.Trim().ToUpper(),
                        password_usuario = tb_password.Text.Trim().ToUpper(),
                        fecha_nacimiento =  dtp_fecha_nacimiento.Value,
                        estado_usuario = cbx_estado.Checked
                    };

                    UsuarioDB usuarioDB = new UsuarioDB();

                    Rpta = usuarioDB.crear_usuario(usuario);


                    if (Rpta.Equals("OK"))
                    {
                        MessageBox.Show("Los datos han sido guardados correctamente",
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                       
                    }
                    else
                    {
                        MessageBox.Show(Rpta,
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }







    }
 }


