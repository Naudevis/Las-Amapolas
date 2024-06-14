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
        List<Hotel> hotelList = new List<Hotel>();
        public static string VIdHotel = "";
        public static string VNombreHotel = "";
        public static string VDireccionHotel = "";
        public static string VCiudadHotel = "";
        public static string VPaisHotel = "";
        public static int VEstrellasHotel = 0;
        public RegistrarHotel()
        {
            InitializeComponent();
        }

        private void RegistrarHotel_Load(object sender, EventArgs e)
        {

            txtIdHotel.Text = VIdHotel;
            txtNombreHotel.Text = VNombreHotel;
            txtDirecionHotel.Text = VDireccionHotel;
            txtCiudadHotel.Text = VCiudadHotel;
            txtPaisHotel.Text = VPaisHotel;
            slEstrellasHotel.Value = VEstrellasHotel;



        }

        private void btnRegistrarHotel_Click(object sender, EventArgs e)
        {


            VIdHotel = txtIdHotel.Text;
            VNombreHotel = txtNombreHotel.Text;
            VDireccionHotel = txtDirecionHotel.Text;
            VCiudadHotel = txtCiudadHotel.Text;
            VPaisHotel = txtPaisHotel.Text;
            VEstrellasHotel = slEstrellasHotel.Value;
        }



        public static bool Vacio()
        {
            if (string.IsNullOrEmpty(VIdHotel) &&
                string.IsNullOrEmpty(VNombreHotel) &&
                string.IsNullOrEmpty(VDireccionHotel) &&
                string.IsNullOrEmpty(VCiudadHotel) &&
                string.IsNullOrEmpty(VPaisHotel)  
              )


            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
