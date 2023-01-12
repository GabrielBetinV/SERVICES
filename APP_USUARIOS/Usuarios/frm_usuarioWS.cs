using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioC;

namespace Usuarios
{
    public partial class frm_usuarioWS : Form
    {
        public frm_usuarioWS()
        {
            InitializeComponent();
        }

        private void frm_usuarioWS_Load(object sender, EventArgs e)
        {

            tb_identificacionBD.Text = UsuarioWS.identificacionBD;
            tb_nombreBD.Text = UsuarioWS.nombre_usuarioBDd;
            tb_loginBD.Text = UsuarioWS.login_usuarioBD;
            tb_passwordBD.Text = UsuarioWS.password_usuarioBD;           
            dtp_fecha_nacimientoBD.Value = UsuarioWS.fecha_nacimientoBD;

            tb_nombreWS.Text = UsuarioWS.nombre_usuarioWS;
            tb_edadWS.Text = UsuarioWS.edad_usuarioWS;
            ckb_activoWS.Checked = UsuarioWS.estado_usuarioWS;

        }
    }
}
