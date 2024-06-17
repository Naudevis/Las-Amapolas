using MaterialSkin.Controls;
using System;
using Las_Amapolas.Formulario;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Las_Amapolas.Formulario.Registrar;
using Las_Amapolas.Clases;

namespace Las_Amapolas.Formulario
{
    public partial class Las_Amapolas : MaterialForm
    {
        public static string Campo = "";
        public  Las_Amapolas()
        {
            InitializeComponent();
        }



        private void Las_Amapolas_Load(object sender, EventArgs e)
        {
 

            contenedor.Controls.Clear();

            FondoInicio fondoInicio = new FondoInicio();

            // Le indicamos que no es el principal (sino que es secundario)
            fondoInicio.TopLevel = false;
            // Permite hacer scroll en caso de desbordamiento de info
            fondoInicio.AutoScroll = true;
            // Quitamos
            fondoInicio.FormBorderStyle = FormBorderStyle.None;
            fondoInicio.Dock = DockStyle.Fill;
            contenedor.Controls.Add(fondoInicio);
            fondoInicio.Show();
           if (Campo=="habitacion")
            {
                contenedor.Controls.Clear();
                RegistrarHabitación registrarHabitación = new RegistrarHabitación();

                // Le indicamos que no es el principal (sino que es secundario)
                registrarHabitación.TopLevel = false;
                // Permite hacer scroll en caso de desbordamiento de info
                registrarHabitación.AutoScroll = true;
                // Quitamos
                registrarHabitación.FormBorderStyle = FormBorderStyle.None;
                registrarHabitación.Dock = DockStyle.Fill;
                contenedor.Controls.Add(registrarHabitación);
                registrarHabitación.Show();
            }




        }


        private void registrarHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();
            RegistrarHotel registrarHotel = new RegistrarHotel();
          
            // Le indicamos que no es el principal (sino que es secundario)
            registrarHotel.TopLevel = false;
            // Permite hacer scroll en caso de desbordamiento de info
            registrarHotel.AutoScroll = true;
            // Quitamos
            registrarHotel.FormBorderStyle = FormBorderStyle.None;
            registrarHotel.Dock = DockStyle.Fill;
            contenedor.Controls.Add(registrarHotel);
            registrarHotel.Show();
        }

        private void registrarHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();
            RegistrarHabitación registrarHabitación = new RegistrarHabitación();

            // Le indicamos que no es el principal (sino que es secundario)
            registrarHabitación.TopLevel = false;
            // Permite hacer scroll en caso de desbordamiento de info
            registrarHabitación.AutoScroll = true;
            // Quitamos
            registrarHabitación.FormBorderStyle = FormBorderStyle.None;
            registrarHabitación.Dock = DockStyle.Fill;
            contenedor.Controls.Add(registrarHabitación);
            registrarHabitación.Show();
        }

        private void Las_Amapolas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void regiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();
            RegistrarReservación registrarReservación = new RegistrarReservación();

            // Le indicamos que no es el principal (sino que es secundario)
            registrarReservación.TopLevel = false;
            // Permite hacer scroll en caso de desbordamiento de info
            registrarReservación.AutoScroll = true;
            // Quitamos
            registrarReservación.FormBorderStyle = FormBorderStyle.None;
            registrarReservación.Dock = DockStyle.Fill;
            contenedor.Controls.Add(registrarReservación);
            registrarReservación.Show();
        }

        private void regitrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();
            RegistrarCliente registrarCliente = new RegistrarCliente();

            // Le indicamos que no es el principal (sino que es secundario)
            registrarCliente.TopLevel = false;
            // Permite hacer scroll en caso de desbordamiento de info
            registrarCliente.AutoScroll = true;
            // Quitamos
            registrarCliente.FormBorderStyle = FormBorderStyle.None;
            registrarCliente.Dock = DockStyle.Fill;
            contenedor.Controls.Add(registrarCliente);
            registrarCliente.Show();

        }

        private void hacerPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();
            RegistrarPago registrarPago = new RegistrarPago();

            // Le indicamos que no es el principal (sino que es secundario)
            registrarPago.TopLevel = false;
            // Permite hacer scroll en caso de desbordamiento de info
            registrarPago.AutoScroll = true;
            // Quitamos
            registrarPago.FormBorderStyle = FormBorderStyle.None;
            registrarPago.Dock = DockStyle.Fill;
            contenedor.Controls.Add(registrarPago);
            registrarPago.Show();

        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();
            RegistrarFactura registrarFactura = new RegistrarFactura();

            // Le indicamos que no es el principal (sino que es secundario)
            registrarFactura.TopLevel = false;
            // Permite hacer scroll en caso de desbordamiento de info
            registrarFactura.AutoScroll = true;
            // Quitamos
            registrarFactura.FormBorderStyle = FormBorderStyle.None;
            registrarFactura.Dock = DockStyle.Fill;
            contenedor.Controls.Add(registrarFactura);
            registrarFactura.Show();

        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();
            RegistrarEmpleado registrarEmpleado = new RegistrarEmpleado();

            // Le indicamos que no es el principal (sino que es secundario)
            registrarEmpleado.TopLevel = false;
            // Permite hacer scroll en caso de desbordamiento de info
            registrarEmpleado.AutoScroll = true;
            // Quitamos
            registrarEmpleado.FormBorderStyle = FormBorderStyle.None;
            registrarEmpleado.Dock = DockStyle.Fill;
            contenedor.Controls.Add(registrarEmpleado);
            registrarEmpleado.Show();

        }

        private void nicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Clear();

            FondoInicio fondoInicio = new FondoInicio();

            // Le indicamos que no es el principal (sino que es secundario)
            fondoInicio.TopLevel = false;
            // Permite hacer scroll en caso de desbordamiento de info
            fondoInicio.AutoScroll = true;
            // Quitamos
            fondoInicio.FormBorderStyle = FormBorderStyle.None;
            fondoInicio.Dock = DockStyle.Fill;
            contenedor.Controls.Add(fondoInicio);
            fondoInicio.Show();
        }

        private void buscarHabitaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campo = "habitacion";
            AbrirData();

        }



        private void buscarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campo = "reservación";
            AbrirData();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campo = "cliente";
            AbrirData();
        }

        private void buscarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campo = "pago";
            AbrirData();
        }

        private void buscarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campo = "factura";
            AbrirData();
        }

        private void buscarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campo = "empleado";
            AbrirData();
        }
        private void AbrirData()
        {
            contenedor.Controls.Clear();

            Tabla fondoInicio = new Tabla();

            // Le indicamos que no es el principal (sino que es secundario)
            fondoInicio.TopLevel = false;
            // Permite hacer scroll en caso de desbordamiento de info
            fondoInicio.AutoScroll = true;
            // Quitamos
            fondoInicio.FormBorderStyle = FormBorderStyle.None;
            fondoInicio.Dock = DockStyle.Fill;
            contenedor.Controls.Add(fondoInicio);
            fondoInicio.Show();
        }
    }
}
