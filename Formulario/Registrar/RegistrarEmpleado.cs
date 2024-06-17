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
    public partial class RegistrarEmpleado : Form
    {
        public RegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            if (!Login.ExisteEmpleado(txtIdEmpleado.Text))
            {

                if (!Login.espaciosVacios(new object[] { txtIdEmpleado, txtNombreEmpleado, txtApellidoEmpleado, txtEmailEmpleado, txtTelefonoEmpleado, txtPosicionEmpleado }))
                {
                    if (Login.EsNumero(new object[] { txtIdEmpleado, txtTelefonoEmpleado }))
                    {

                        if (!Login.DigitosTelefono(new object[] { txtTelefonoEmpleado }))
                        {
                            if (!Login.NumeroCedula(new object[] { txtIdEmpleado }))
                            {
                                if (!Login.EsTexto(new object[]{ txtNombreEmpleado, txtApellidoEmpleado, txtPosicionEmpleado} ))
                                 {
                                     if (!Login.MayorTresLetras(new object[] { txtNombreEmpleado, txtApellidoEmpleado, txtEmailEmpleado, txtPosicionEmpleado }))
                                     {
                                        if (Login.EsEmail(txtEmailEmpleado.Text))
                                        {
                                            Empleado EmpleadoTemporal = new Empleado(
                                             txtIdEmpleado.Text, txtNombreEmpleado.Text, txtApellidoEmpleado.Text, txtEmailEmpleado.Text, Convert.ToInt32(txtTelefonoEmpleado.Text), txtPosicionEmpleado.Text);


                                            Login.listEmpleado.Add(EmpleadoTemporal);
                                            MessageBox.Show($"El empleado {txtIdEmpleado.Text} se registro exitosamente");
                                            txtIdEmpleado.Text = "";
                                            txtNombreEmpleado.Text = "";
                                            txtApellidoEmpleado.Text = "";
                                            txtEmailEmpleado.Text = "";
                                            txtTelefonoEmpleado.Text = "";
                                            txtPosicionEmpleado.Text = "";
                                            

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
                MessageBox.Show($"El empleado {txtIdEmpleado.Text} ya existe");
            }
        }
    }
}
