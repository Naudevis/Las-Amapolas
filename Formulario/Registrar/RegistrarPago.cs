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
        public RegistrarPago()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            Pago PagoTemporal = new Pago(
    Convert.ToInt32(txtIdPago.Text), txtReservaIdPago.Text,Convert.ToInt32( txtMontoPago.Text), datePago.Text, cbMetodoPago.Text);


            Login.listPago.Add(PagoTemporal);
        }
    }
}
