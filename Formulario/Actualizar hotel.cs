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
        List<Hotel> hotelList=new List<Hotel>();
        string VIdHotel = "";
        string VNombreHotel = "";
        string VDireccionHotel = "";
        string VCiudadHotel = "";
        string VPaisHotel = "";
        int VEstrellasHotel = 0;
        public RegistrarHotel()
        {
            InitializeComponent();
        }

        private void RegistrarHotel_Load(object sender, EventArgs e)
        {


          VIdHotel = "AV456197";
             VNombreHotel = "Las Amapolas";
             VDireccionHotel = "100 metros norte del hospital";
             VCiudadHotel = "Upala";
             VPaisHotel = "Costa Rica";
             VEstrellasHotel = 4;

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
    }
}
