using Las_Amapolas.Clases;
using MaterialSkin.Controls;
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
    public partial class RegistrarHabitación : Form
    {



        public static int contadorHabitaciones = 3;

        public static List<Habitación> habitacion = new List<Habitación> ();
        public RegistrarHabitación()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            if (!Login.espaciosVacios(new object[] { txtIdHabitacion, txtNumeroHabitacion, txtPrecioHabitacion }))
            {
                if (!Login.ComboBoxVacios(new object[] { cbTipoHabitacion }))
                {


                    if (Login.EsNumero(new object[] { txtPrecioHabitacion }))
                    {
                        if (slCapacidadHabitacion.Value >0)
                        {
                            Habitación HabitacionTemporal = new Habitación(
                            txtIdHabitacion.Text, txtNumeroHabitacion.Text, cbTipoHabitacion.Text, slCapacidadHabitacion.Value, Convert.ToDouble(txtPrecioHabitacion.Text), Login.objHotel.HotelId);


                            Login.listHabitaciones.Add(HabitacionTemporal);


                            MessageBox.Show($"La habitación {txtIdHabitacion.Text} se registro exitosamente");
                            contadorHabitaciones++;
                            txtIdHabitacion.Text = "" + contadorHabitaciones;
                            txtNumeroHabitacion.Text = "";
                            txtPrecioHabitacion.Text = "";
                            txtTipoDeHabitacion.Text = "";
                            slCapacidadHabitacion.Value = 0;

                            cbTipoHabitacion.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("La capacidad de una habitación debe ser mayor a 0");
                        }
                    }
                }

            }

            txtTipoDeHabitacion.Visible = false;
            btnAgregar.Visible = false;



        }

        private void cbTipoHabitacion_Click(object sender, EventArgs e)
        {
            cbTipoHabitacion.Items.Clear();
            for (int i = 0; i < Login.Tipos.Length; i++)
            {
                cbTipoHabitacion.Items.Add(Login.Tipos[i]);
            }
        }

        private void RegistrarHabitación_Load(object sender, EventArgs e)
        {
            txtTipoDeHabitacion.Visible = false;
            btnAgregar.Visible = false;
            txtHotelIdHabitacion.Text = Login.objHotel.HotelId;

            txtIdHabitacion.Text = ""+contadorHabitaciones;



        }


        private void btnLlamarRegistrarHabitacion_Click(object sender, EventArgs e)
        {
            txtTipoDeHabitacion.Visible=true;
            btnAgregar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Array.Resize(ref Login.Tipos, Login.Tipos.Length+1);
            Login.Tipos[Login.Tipos.Length - 1] = txtTipoDeHabitacion.Text;
            txtTipoDeHabitacion.Visible = false;
            btnAgregar.Visible = false;
        }
    }
}
