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
    public partial class RegistrarHabitación : Form
    {
      

        List<Habitación> habitacion = new List<Habitación> ();
        public RegistrarHabitación()
        {
            InitializeComponent();
        }

        private void materialTextBox24_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoHabitacion_Click(object sender, EventArgs e)
        {

             Habitación Ha = new Habitación(
                 txtIdHabitacion.Text,txtNumeroHabitacion.Text,cbTipoHabitacion.Text,slCapacidadHabitacion.Value,Convert.ToDouble(txtPrecioHabitacion.Text),RegistrarHotel.VIdHotel);


            habitacion.Add(Ha);
        }

        private void RegistrarHabitación_Load(object sender, EventArgs e)
        {
            
        
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
            cbTipoHabitacion.Items.AddRange(Tipos);

        }
    }
}
