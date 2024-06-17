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

    public partial class RegistrarPago : Form
    {
        int ContadorPagos = 104;
        public static string[] Metodos = new string[5];
        public RegistrarPago()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            if (!Login.espaciosVacios(new object[] { txtMontoPago, txtReservaIdPago }))
            {
                if (!Login.ComboBoxVacios(new object[] { cbMetodoPago }))   
                {
                    if (Login.ExisteReservacion(txtReservaIdPago.Text))
                    {
                        if (Login.EsNumero(new object[] { txtMontoPago }))
                        {
                            if (Login.PagoReservacion(txtReservaIdPago.Text,txtMontoPago.Text))
                            {
                                
                                Pago PagoTemporal = new Pago(
                                Convert.ToInt32(txtIdPago.Text), txtReservaIdPago.Text, Convert.ToInt32(txtMontoPago.Text), datePago.Text, cbMetodoPago.Text);


                                Login.listPago.Add(PagoTemporal);
                                txtMetodo.Visible = false;
                                btnGuardarMetodo.Visible = false;
                                MessageBox.Show($"El pago {txtIdPago.Text} se registro exitosamente");
                                ContadorPagos++;
                                txtIdPago.Text = "" + ContadorPagos;
                                txtReservaIdPago.Text = "";
                                txtMontoPago.Text = "";
                                txtMondoPendiente.Text = "";
                                txtMetodo.Text = "";
                                cbMetodoPago.Items.Clear();
                                
                            }
                        }
                       

                    }
                    else
                    {
                        MessageBox.Show("La reservación no existe");
                    }
                }

            }
        }

        private void RegistrarPago_Load(object sender, EventArgs e)
        {
            InicializarMedotodos();
            txtIdPago.Text = "" + ContadorPagos;
            txtMetodo.Visible = false;
            btnGuardarMetodo.Visible = false;
        }

        private void InicializarMedotodos()
        {
            Metodos[0] = "Transferencia bancaria";
            Metodos[1] = "Cheque";
            Metodos[2] = "Tarjeta de débito";
            Metodos[3] = "Tarjeta de crédito";
            Metodos[4] = "Efectivo";

        }

        private void cbMetodoPago_Click(object sender, EventArgs e)
        {
            cbMetodoPago.Items.Clear();
            foreach (string metodo in Metodos)
            {

                cbMetodoPago.Items.Add(metodo);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMetodo.Visible = true;
            btnGuardarMetodo.Visible = true;

        }

        private void btnGuardarMetodo_Click(object sender, EventArgs e)
        {
            bool metodoExiste = Array.Exists(Metodos, Filtro => Filtro.ToUpper() == txtMetodo. Text.ToUpper());
            if (!metodoExiste)
            {

                Array.Resize(ref Metodos, Metodos.Length + 1);
                Metodos[Metodos.Length - 1] = txtMetodo.Text;
                txtMetodo.Visible = false;
                btnGuardarMetodo.Visible = false;
            }
            else
            {
                MessageBox.Show($"El metodo {txtMetodo. Text} ya existe");
            }
        }

        private void btnLlamarRegistrarReservación_Click(object sender, EventArgs e)
        {
            RegistrarReservación nuevaReservación = new RegistrarReservación();
            nuevaReservación.Show();
        }

        private void txtReservaIdPago_TextChanged(object sender, EventArgs e)
        {
            txtMondoPendiente.Text = Convert.ToString(Login.precioPorNoche(txtReservaIdPago.Text) - Login.SumaPagos(txtReservaIdPago.Text));
        }
    }
}
