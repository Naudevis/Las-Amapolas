using Las_Amapolas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Las_Amapolas.Formulario.Registrar
{
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void materialTextBox23_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente ClienteTemporal = new Cliente(
                txtIdCliente.Text, txtNombreCliente.Text, txtApellidoCliente.Text, txtEmailCliente.Text, Convert.ToInt32(txtTelefonoCliente.Text),  txtDireccionCliente.Text);


            Login.listClientes.Add(ClienteTemporal);
        }
    }
}
