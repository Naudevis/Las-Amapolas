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
    public partial class RegistrarHotel : Form

    {

        public RegistrarHotel()
        {
            InitializeComponent();
        }

        private void RegistrarHotel_Load(object sender, EventArgs e)
        {

            txtIdHotel.Text = Login.objHotel.HotelId;


            txtNombreHotel.Text = Login.objHotel.Nombre;
            txtDirecionHotel.Text = Login.objHotel.Direccion;
            txtCiudadHotel.Text = Login.objHotel.Ciudad;
            txtPaisHotel.Text = Login.objHotel.Pais;
            slEstrellasHotel.Value = Login.objHotel.Estrellas;



        }

        private void btnRegistrarHotel_Click(object sender, EventArgs e)
        {


           Login.objHotel.Nombre = txtNombreHotel.Text;
           Login.objHotel.Direccion = txtDirecionHotel.Text;
            Login.objHotel.Ciudad = txtCiudadHotel.Text;
           Login.objHotel.Pais = txtPaisHotel.Text;
            Login.objHotel.Estrellas = slEstrellasHotel.Value;
        }


        private void cbHabitacionesHotel_Click(object sender, EventArgs e)
        {
            cbHabitacionesHotel.Items.Clear();
            foreach (Habitación habitacion in Login.listHabitaciones)
            {
                cbHabitacionesHotel.Items.Add(habitacion.HabitacionId);

            }
        }
    }
}
