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
    public partial class RegistrarReservación : Form
    {
        public RegistrarReservación()
        {
            InitializeComponent();
        }

        private void RegistrarReservación_Load(object sender, EventArgs e)
        {
            CargarHabitaciones();
            CargarClientes();
        }

        private void CargarClientes()
        {

            for (int i = 0; i < Login.listClientes.Count; i++)
            {
                cbClienteReserva.Items.Add(Login.listClientes[i].Id);

            }

        }

        private void CargarHabitaciones()
        {
            for (int i = 0; i < Login.listHabitaciones.Count; i++)
            {
                cbNumeroHabitacionReserva.Items.Add(Login.listHabitaciones[i].Numero);

            }
        }

        private void btnRegistrarReserva_Click(object sender, EventArgs e)
        {
            Reserva ReservaTemporal = new Reserva(
            txtIdReserva.Text, cbClienteReserva.Text, cbNumeroHabitacionReserva.Text, dateInicioReserva.Text,dateFinReserva.Text,$" {chbEstadoReservacion.Checked}");


            Login.listReservacion.Add(ReservaTemporal);
        }

        private void cbHabitacionIdReserva_TextChanged(object sender, EventArgs e)
        {
            string numeroHabitacion = cbNumeroHabitacionReserva.SelectedItem.ToString();
            txtPrecioHabitacion.Text = " " + obtenerPrecioHabitacion(numeroHabitacion);
            txtTipoReservacion.Text = " " + obtenerTipoHabitacion(numeroHabitacion);
        }

        private double obtenerPrecioHabitacion(string numeroHabitacion)
        {
            double precioEncontrado = 0.0;
            for (int i = 0;i<Login.listHabitaciones.Count; i++)
            {
                if (Login.listHabitaciones[i].Numero == numeroHabitacion)
                {
                    precioEncontrado = Login.listHabitaciones[i].PrecioPorNoche;
                    break;
                }
            }

                return precioEncontrado;
        }
        private string obtenerTipoHabitacion(string numeroHabitacion)
        {
            string TipoEncontrado = "";
            for (int i = 0; i < Login.listHabitaciones.Count; i++)
            {
                if (Login.listHabitaciones[i].Numero == numeroHabitacion)
                {
                    TipoEncontrado = Login.listHabitaciones[i].Tipo;
                    break;
                }
            }

            return TipoEncontrado;
        }
    }
}
