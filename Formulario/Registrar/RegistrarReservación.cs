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

        public static int contadorReservaciones = 103;
        public RegistrarReservación()
        {
            InitializeComponent();
        }

        private void btnRegistrarReserva_Click(object sender, EventArgs e)
        {
            
            if (!Login.espaciosVacios(new object[] {txtClienteId }))
            {

                if (!Login.ComboBoxVacios(new object[] { cbNumeroHabitacionReserva }))
                {
                    if (Login.EsNumero(new object[] { txtClienteId }))
                    {
                        if (!Login.NumeroCedula(new object[] { txtClienteId }))
                        {
                            if (Login.ExisteCliente(txtClienteId.Text))
                            {
                                if (Fecha(dateInicioReserva.Text, dateFinReserva.Text,cbNumeroHabitacionReserva.Text))
                                {

                                    Reserva ReservaTemporal = new Reserva(
                                    txtIdReserva.Text, txtClienteId.Text, cbNumeroHabitacionReserva.Text, dateInicioReserva.Text, dateFinReserva.Text, $" {chbEstadoReservacion.Checked}");


                                    Login.listReservacion.Add(ReservaTemporal);

                                    MessageBox.Show($"La reservación {txtIdReserva.Text} se registro exitosamente");
                                    contadorReservaciones++;
                                    txtIdReserva.Text = "" + contadorReservaciones;
                                    txtClienteId.Text = "";
                                    txtPrecioHabitacion.Text = "";
                                    txtTipoReservacion.Text = "";
                                    chbEstadoReservacion.Checked = false;
                                    cbNumeroHabitacionReserva.Items.Clear();
                                }
                                else
                                {
                                    MessageBox.Show($"La fecha está dentro de una reservación existente");
                                }
                            }

                            else
                            {
                                MessageBox.Show($"El cliente {txtClienteId.Text} no existe");
                            }
                        }
                    }
                }
            }
        }

        private void btnLlamarRegistrarCliente_Click(object sender, EventArgs e)
        {
            RegistrarCliente nuevoCliente = new RegistrarCliente();

            nuevoCliente.Show();
        }
        private void cbHabitacionIdReserva_TextChanged(object sender, EventArgs e)
        {
            string numeroHabitacion = cbNumeroHabitacionReserva.SelectedItem.ToString();
            txtPrecioHabitacion.Text = " " + obtenerPrecioHabitacion(numeroHabitacion);
            txtTipoReservacion.Text = " " + obtenerTipoHabitacion(numeroHabitacion);
            //RecomedarFecha(cbNumeroHabitacionReserva.Text);
        }

        //Cargar número de habitaciones

        private void RegistrarReservación_Load(object sender, EventArgs e)
        {
            CargarHabitaciones();
            txtIdReserva.Text = "" + contadorReservaciones;

        }


        private void CargarHabitaciones()
        {
            for (int i = 0; i < Login.listHabitaciones.Count; i++)
            {
                cbNumeroHabitacionReserva.Items.Add(Login.listHabitaciones[i].Numero);
            }
        }



        // Funciones
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

        private void cbNumeroHabitacionReserva_Click(object sender, EventArgs e)
        {
            cbNumeroHabitacionReserva.Items.Clear();
            CargarHabitaciones();
        }



        private bool Fecha(string fecha, string fecha2, string NumeroHabitacion1)
        {
            bool fueraDeRango = false;
            DateTime NuevaFechaInicio = Convert.ToDateTime(fecha);
            DateTime NuevaFechaFinal = Convert.ToDateTime(fecha2);
            DateTime FechaInicio;
            DateTime FechaFin;
            string NumeroHabitacion2;
            string Estado;
            for (int i = 0; i < Login.listReservacion.Count; i++)
            {
                FechaInicio = Convert.ToDateTime(Login.listReservacion[i].FechaInicio);
                FechaFin = Convert.ToDateTime(Login.listReservacion[i].FechaFin);
                 NumeroHabitacion2 = Login.listReservacion[i].HabitacionId;
                Estado = Login.listReservacion[i].Estado;

                if (NuevaFechaInicio > DateTime.Now)
                {
                    if ((NumeroHabitacion1 == NumeroHabitacion2) && (Estado == " True") ||  (Estado == "True"))
                    {


                        if (  ((NuevaFechaFinal < FechaInicio && NuevaFechaInicio < FechaInicio) || (NuevaFechaInicio > FechaFin && NuevaFechaFinal > FechaFin)))
                        {

                            fueraDeRango = true;
                            
                        }
                        else 
                        {

                            fueraDeRango = false;
                            return fueraDeRango;
                            
                        }
                    }
                }

            }


            return fueraDeRango;
        }


        /*
        private void RecomedarFecha( string NumeroHabitacion1)
        {
            bool fueraDeRango = false;


            DateTime NuevaFechaInicio = DateTime.Today;
            DateTime NuevaFechaFinal= DateTime.Today;
           

            DateTime FechaInicio;
            DateTime FechaFin;
            string NumeroHabitacion2;
            string Estado;
            int contador = 0;
            int contador2 = 0;
            for (int i = 0; i < Login.listReservacion.Count; i++)
            {

                FechaInicio = Convert.ToDateTime(Login.listReservacion[i].FechaInicio);
                FechaFin = Convert.ToDateTime(Login.listReservacion[i].FechaFin);
                NumeroHabitacion2 = Login.listReservacion[i].HabitacionId;
                Estado = Login.listReservacion[i].Estado;



                if ((NumeroHabitacion1 == NumeroHabitacion2) && (Estado == " True") || (Estado == "True"))
                {
                    contador2++;
                    if (i % contador2 == 1 && NuevaFechaInicio > FechaFin)
                    {
                        contador = 1;
                        NuevaFechaInicio = FechaFin.AddDays(1);
                    }
                    else { contador = 0; }

                }
                if (contador == 1 && NuevaFechaFinal < FechaInicio)
                {
                    fueraDeRango = true;
                    NuevaFechaFinal = FechaInicio.AddDays(-1);

                    dateInicioReserva.Text = ""+ NuevaFechaInicio;
                    dateFinReserva.Text= ""+NuevaFechaFinal;
                            break;
                }
            }*/
                         




                


            


           
        
    }




   
}

