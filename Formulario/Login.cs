using Las_Amapolas.Clases;
using Las_Amapolas.Formulario.Registrar;

using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Las_Amapolas.Formulario
{
    public partial class Login : MaterialForm
    {
        public static List<Habitación> listHabitaciones = new List<Habitación>();
        public static List<Cliente> listClientes = new List<Cliente>();
        public static List<Empleado> listEmpleado = new List<Empleado>();
        public static List<Factura> listFactura = new List<Factura>();
        public static List<Pago> listPago = new List<Pago>();
        public static List<Reserva> listReservacion = new List<Reserva>();


        /* 
                

    
         public static List<Habitación> habitaciones = new List<Habitación>();*/



        public static string[] usuario = { "Admin" };
        public static string[] contrasennia = { "123" };
       public static  Hotel objHotel = new Hotel("AV456197", "Las Amapolas", "Puntarenas, Jacó", "Jacó","Costa Rica",4);
        Cliente objCliente ;

        Habitación classHabitacion;
        Cliente classCliente;

        public Login()
        {
            InitializeComponent();
        }



        private void materialButton1_Click(object sender, EventArgs e)
        {
            string usuarioAutentica = txtUsuario.Text;
            string passwdAutentica = txtPassword.Text;

            bool existeUsuario = Array.Exists(usuario, filtro => filtro.ToUpper() == usuarioAutentica.ToUpper());
            bool existePasswd = Array.Exists(contrasennia, filtro => filtro == passwdAutentica);

            if (existePasswd && existeUsuario)
            {
                Las_Amapolas principal = new Las_Amapolas();
                principal.Show();
                Visible = false;//ocultar la ventana
            }
            else
            {
                MessageBox.Show(
                    "Usuario y/o contraseña no coinciden",
                    "Error de acceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            InicializarHabitaciones();
            InicializarClientes();
        }

        private void InicializarClientes()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                classCliente = new Cliente($"20826019{i}", $"Nombre {i}", $"Apellido {i}", $"raudyncamacho{i}@gmail.com", 887070+i , "Upala");
                listClientes.Add(classCliente);
            }

        }
        /// <summary>
        /// Creamos habitaciones 
        /// </summary>
        private void InicializarHabitaciones()

        {
            Random rnd = new Random();
            for ( int i = 0;i<5; i++ )
            {
                classHabitacion = new Habitación($"{i}", $"N {i}","Individual", rnd.Next(10), rnd.Next(25000), "AV456197");
                listHabitaciones.Add( classHabitacion );
            }
            objHotel.Habitaciones= listHabitaciones;

        }

    }
}
