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
            if (!Login.ExisteCliente(txtIdCliente.Text))
            {

                if (!Login.espaciosVacios(new object[] { txtIdCliente, txtNombreCliente, txtApellidoCliente, txtEmailCliente, txtTelefonoCliente, txtDireccionCliente }))
                {
                    if (Login.EsNumero(new object[] { txtIdCliente, txtTelefonoCliente }))
                    {

                        if (!Login.DigitosTelefono(new object[] { txtTelefonoCliente }))
                        {
                            if (!Login.NumeroCedula(new object[] { txtIdCliente }))
                            {
                                if (!Login.EsTexto(new object[] { txtNombreCliente, txtApellidoCliente, txtDireccionCliente }))
                                {
                                    if (!Login.MayorTresLetras(new object[] { txtNombreCliente, txtApellidoCliente, txtDireccionCliente }))
                                    {
                                        if (Login.EsEmail(txtEmailCliente.Text))
                                        {


                                            if (Login.EsNumero(new object[] { txtIdCliente }))
                                            {
                                                Cliente ClienteTemporal = new Cliente(
                                                    txtIdCliente.Text, txtNombreCliente.Text, txtApellidoCliente.Text, txtEmailCliente.Text, Convert.ToInt32(txtTelefonoCliente.Text), txtDireccionCliente.Text);


                                                Login.listClientes.Add(ClienteTemporal);

                                                MessageBox.Show($"El cliente {txtIdCliente.Text} se registro exitosamente");
                                                txtIdCliente.Text = "";
                                                txtNombreCliente.Text = "";
                                                txtApellidoCliente.Text = "";
                                                txtEmailCliente.Text = "";
                                                txtDireccionCliente.Text = "";
                                                txtTelefonoCliente.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($"El cliente {txtIdCliente.Text} ya existe");
            }
        }

    }
}