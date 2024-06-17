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
using static System.Net.Mime.MediaTypeNames;

namespace Las_Amapolas.Formulario.Registrar
{
    public partial class RegistrarFactura : Form
    {
        public static int ContadorFactura = 104;
        public RegistrarFactura()
        {
            InitializeComponent();
        }

        private void btnResgistrarFactura_Click(object sender, EventArgs e)
        {
            if (!Login.espaciosVacios(new object[] { txtReservaIdFatura, txtEmpleadoIdFatura }))
       
            {
                if (Login.EsNumero(new object[] { txtEmpleadoIdFatura, txtReservaIdFatura }))
                {
                    if (Login.ExisteReservacion(txtReservaIdFatura.Text))
                    {
                        if (!Login.ExisteReservacionFactura(txtReservaIdFatura.Text))
                        {
                            if (!Login.NumeroCedula(new object[] { txtEmpleadoIdFatura }))
                            {

                                if (Login.ExisteEmpleado(txtEmpleadoIdFatura.Text))
                                {
                                    Factura FacturaTemporal = new Factura(
                                     Convert.ToInt32(txtIdFatura.Text), txtReservaIdFatura.Text, txtClienteIdFatura.Text, txtEmpleadoIdFatura.Text, Convert.ToDouble(txtMontoTotalFatura.Text), dateEmisionFatura.Text);

                                    Login.listFactura.Add(FacturaTemporal);


                                    MessageBox.Show($"La factura {txtIdFatura.Text} se registro exitosamente");

                                    ContadorFactura++;
                                    txtIdFatura.Text = "" + ContadorFactura;
                                    txtReservaIdFatura.Text = "";
                                    txtEmpleadoIdFatura.Text = "";
                                    txtClienteIdFatura.Text = "";
                                    txtMontoTotalFatura.Text = "0";
                                   
                                }
                                else
                                {
                                    MessageBox.Show(
                                    $"El empleado no existe",
                                    "Error de acceso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            $"La reservación ya se facturo",
                            "Error de acceso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        $"La reservación no existe",
                        "Error de acceso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        
                    }
                }
                else
                {
  
                    
                }
            }

        }



        private void txtReservaIdFatura_TextChanged(object sender, EventArgs e)
        {
            txtClienteIdFatura.Text = "" + ClienteBuscar(txtReservaIdFatura.Text);
            txtMontoTotalFatura.Text = ""+buscarMonto(txtReservaIdFatura.Text);
        }

        private void RegistrarFactura_Load(object sender, EventArgs e)
        {
            txtIdFatura.Text = "" + ContadorFactura;
            txtMontoTotalFatura.Text = "0";
        }
        public static double buscarMonto(string reservaId)
        {
            double MontoTotal = 0.0;
            string habitacionId = "";
            for (int i = 0; i < Login.listReservacion.Count; i++)
            {
                if (Login.listReservacion[i].Id == reservaId)
                {
                    habitacionId = Login.listReservacion[i].HabitacionId;
                    break;
                }

            }

            for (int i = 0; i < Login.listHabitaciones.Count; i++)
            {
                if (Login.listHabitaciones[i].Numero == habitacionId)
                {
                    MontoTotal = Login.listHabitaciones[i].PrecioPorNoche;
                    break;
                }
            }
            return MontoTotal;
        }

        public static string ClienteBuscar(string reservaId)
        {
            string Cliente = "";
      
            for (int i = 0; i < Login.listReservacion.Count; i++)
            {
                if (Login.listReservacion[i].Id == reservaId)
                {
                    Cliente = Login.listReservacion[i].ClienteId;
                    break;
                }

            }

            return Cliente;
        }
    }
}
