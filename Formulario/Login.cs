using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Las_Amapolas.Formulario
{
    public partial class Login : MaterialForm
    {
        public static string[] usuario = { "Admin" };
        public static string[] contrasennia = { "123" };
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string usuarioAutentica = txtUsuario.Text;
            string passwdAutentica = txtPassword.Text;

            bool existeUsuario = Array.Exists(usuario, filtro => filtro.ToUpper() == usuarioAutentica.ToUpper());
            bool existePasswd = Array.Exists(contrasennia, filtro => filtro == passwdAutentica);

            if (existePasswd && existeUsuario)
            {
                Las_Amapolas principal = new Las_Amapolas();
                principal.Show();
                Visible = false;//ocultar la ventana
            }
            else
            {
                MessageBox.Show(
                    "Usuario y/o contraseña no coinciden",
                    "Error de acceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
