
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

namespace Las_Amapolas.Formulario
{
    public partial class FondoInicio : Form
    {
        public FondoInicio()
        {
            InitializeComponent();
        }

        private void FondoInicio_Load(object sender, EventArgs e)

        {
            lblId.Text += Login.objHotel.HotelId;
            lblDireccion.Text += Login.objHotel.Direccion;
            lblEstrellas.Text += Login.objHotel.Estrellas;
            lblPais.Text += Login.objHotel.Pais;
        }
    }
}
