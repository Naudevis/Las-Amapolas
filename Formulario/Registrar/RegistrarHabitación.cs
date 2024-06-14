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
      

        public static List<Habitación> habitacion = new List<Habitación> ();
        public RegistrarHabitación()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (espaciosVacios(new object[] { txtIdHabitacion, txtNumeroHabitacion, txtPrecioHabitacion }))
            {
                Habitación HabitacionTemporal = new Habitación(
                txtIdHabitacion.Text, txtNumeroHabitacion.Text, cbTipoHabitacion.Text, slCapacidadHabitacion.Value, Convert.ToDouble(txtPrecioHabitacion.Text), Login.objHotel.HotelId);


                Login.listHabitaciones.Add(HabitacionTemporal);
            }
        }

        private void cbTipoHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarHabitación_Load(object sender, EventArgs e)
        {

            txtHotelIdHabitacion.Text = Login.objHotel.HotelId;

            string[] Tipos = {

               "Habitación estándar",
                "Suite",
                "Habitación ejecutiva",
                "Habitación familiar",
                "Habitación con vista",
                "Habitación temática",
                "Habitación adaptada para personas con discapacidad",
                "Habitación compartida o dormitorio"


            };

            for (int i = 0; i < Tipos.Length; i++)
            {
                cbTipoHabitacion.Items.Add(Tipos[i]);
            }


        }

        private static bool espaciosVacios(Object[] campos)
        {
            bool vacios = false;
            for (int i = 0;i < campos.Length;i++)

            {
                MaterialTextBox2 campo = (MaterialTextBox2)campos[i];
                if(string.IsNullOrEmpty(campo.Text))
                {
                    MessageBox.Show($"El campo {campo.Hint} está vacío");
                    vacios = true;
                    break;
                }
            }
            return vacios;
        }

    }
}
