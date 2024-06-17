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

        public Login()
        {
            InitializeComponent();
        }

        public static List<Habitación> listHabitaciones = new List<Habitación>();
        public static List<Cliente> listClientes = new List<Cliente>();
        public static List<Empleado> listEmpleado = new List<Empleado>();
        public static List<Factura> listFactura = new List<Factura>();
        public static List<Pago> listPago = new List<Pago>();
        public static List<Reserva> listReservacion = new List<Reserva>();

        public static string[] usuario = { "Admin" };
        public static string[] contrasennia = { "123" };


        Habitación classHabitacion;
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



            InicializarEmpleados();
            InicializarHabitaciones();
            InicializarClientes();
            InicializarReservacion();
            InicializarFactura();
            InicializarPago();
        }






        //Inicializaciones

        #region Inicializacion de Hotel
        public static Hotel objHotel = new Hotel("AV456197", "Las Amapolas", "Puntarenas, Jacó", "Jacó", "Costa Rica", 4);
        #endregion
        #region Inicializacion de Clientes
        //Datos Clientes
        string[] CId = { "208260696", "208002555", "566466458" };
        string[] CNombre = { "Carlos", "Luis", "Karina" };
        string[] CApellido = { "Salazar", "Rodriguez", "Ortiz" };
        string[] CEmail = { "Carlos@gmail.com", "Luis@gamil.com", "Karina@gmail.com" };
        string[] CDireccion = { "Upala", "Las Latas", "Caño Blanco" };
        int[] CTelefono = { 87546682, 74854126, 54535852 };
        private void InicializarClientes()
        {
            for (int i = 0; i < EmId.Length; i++)
            {

                Empleado empleados = new Empleado(
                    EmId[i],
                    EmNombre[i],
                    EmApellido[i],
                    EmEmail[i],
                    EmTelefono[i],
                    EmPosicion[i]

                    );
                listEmpleado.Add(empleados);

            }
        }

        #endregion
        #region Inicializacion de Empleados
        // Datos de Empleados
        string[] EmId = { "208260196", "208002565", "208253462" };
        string[] EmNombre = { "Mario", "Ana", "José" };
        string[] EmApellido = { "Salazar", "Rodriguez", "Ortiz" };
        string[] EmEmail = { "mariaS@gmail.com", "AnaR@gamil.com", "JosOrtiz@gmail.com" };
        string[] EmPosicion = { "Gerente", "Resepcionista", "Conserje" };
        int[] EmTelefono = { 87549512, 54855126, 12457852 };
        private void InicializarEmpleados()
        {
            for (int i = 0; i < CId.Length; i++)
            {

                Cliente clientes = new Cliente(
                    CId[i],
                    CNombre[i],
                    CApellido[i],
                    CEmail[i],
                    CTelefono[i],
                    CDireccion[i]

                    );
                listClientes.Add(clientes);

            }
        }
        #endregion
        #region Inicializacion de Reservacion
        // Datos Reserva
        string[] RId = { "100", "101", "102" };
        string[] RClienteId = { "208260696", "208050255", "566456658" };
        string[] RNumeroHabitacion = { "N0", "N1", "N2" };
        string[] RFechaInicio = { "viernes, 14 de junio de 2024", "viernes, 14 de junio de 2024", "viernes, 14 de junio de 2024" };
        string[] RFechaFin = { "viernes, 28 de junio de 2024", "viernes, 28 de junio de 2024", "viernes, 28 de junio de 2024" };
        string[] REstado = { " True", " True", " True" };

        private void InicializarReservacion()
        {
            for (int i = 0; i < RId.Length; i++)
            {

                Reserva reservaciones = new Reserva(
                    RId[i],
                    RClienteId[i],
                    RNumeroHabitacion[i],
                    RFechaInicio[i],
                    RFechaFin[i],
                    REstado[i]

                    );
                listReservacion.Add(reservaciones);

            }
        }
        #endregion
        #region Inicializacion de Facturas
        //  Datos Factura
        int[] FId = { 101, 102, 103 };
        string[] FReservaId = { "65", "56", "864" };
        string[] FClienteId = { "208260696", "20800255", "56646658" };
        string[] FEmpleadoId = { "208260196", "208002565", "208253462" };
        double[] FMontoTotal = { 10000, 50000, 25000 };
        string[] FFechaEmision = { "viernes, 14 de junio de 2024", "viernes, 14 de junio de 2024", "viernes, 14 de junio de 2024" };

        private void InicializarFactura()
        {
            for (int i = 0; i < FId.Length; i++)
            {
                Factura facturas = new Factura(
                    FId[i],
                    FReservaId[i],
                    FClienteId[i],
                    FEmpleadoId[i],
                    FMontoTotal[i],
                    FFechaEmision[i]

                    );
                listFactura.Add(facturas);
            }
        }
        #endregion
        #region Inicializacion de Pagos
        //Datos Pago
        int[] PId = { 101, 102, 103 };
        string[] PReservaId = { "65", "56", "864" };
        double[] PMonto = { 10000, 50000, 25000 };
        string[] PFechaPago = { "viernes, 21 de junio de 2024", "viernes, 21 de junio de 2024", "viernes, 21 de junio de 2024" };
        string[] PMetodoPago = { "Efectivo", "Transferencia bancaria", "Cheque" };
        private void InicializarPago()
        {
            for (int i = 0; i < PId.Length; i++)
            {
                Pago pagos = new Pago(
                    PId[i],
                    PReservaId[i],
                    PMonto[i],
                    PFechaPago[i],
                    PMetodoPago[i]

                    );
                listPago.Add(pagos);
            }
        }
        #endregion
        #region Inicializacion de Habitaciones
        private void InicializarHabitaciones()

        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                classHabitacion = new Habitación($"{i}", $"N{i}", "Individual", rnd.Next(10), rnd.Next(25000), "AV456197");
                listHabitaciones.Add(classHabitacion);
            }
            objHotel.Habitaciones = listHabitaciones;

        }

        #endregion
        #region Inicializacion de Tipos
        public static string[] Tipos =
   {

               "Habitación estándar",
                "Suite",
                "Habitación ejecutiva",
                "Habitación familiar",
                "Habitación con vista",
                "Habitación temática",
                "Habitación adaptada para personas con discapacidad",
                "Habitación compartida o dormitorio"


            };
        #endregion

        // Creamos las funciones globales

        #region Funcion Text Vacios
        public static bool espaciosVacios(Object[] campos)
        {
            bool vacios = false;
            for (int i = 0; i < campos.Length; i++)

            {
                MaterialTextBox2 campo = (MaterialTextBox2)campos[i];
                if (string.IsNullOrEmpty(campo.Text))
                {
                    MessageBox.Show($"El campo {campo.Hint} está vacío");
                    vacios = true;
                    break;
                }
            }
            return vacios;
        }
        #endregion}
        #region Funcion ComboBox vacios
        public static bool ComboBoxVacios(Object[] campos)
        {
            bool vacios = false;
            for (int i = 0; i < campos.Length; i++)

            {
                MaterialComboBox campo = (MaterialComboBox)campos[i];
                if (string.IsNullOrEmpty(campo.Text))
                {
                    MessageBox.Show($"El campo {campo.Hint} está vacío");
                    vacios = true;
                    break;
                }
            }
            return vacios;
        }
        #endregion
        #region Funcion Es Numero
        public static bool EsNumero(object[] campos)
        {
            foreach (object obj in campos)
            {
                if (obj is MaterialTextBox2 campo)
                {

                    bool esNumerico = ElNumeroEsTexto(campo.Text);

                    if (!esNumerico)
                    {
                        MessageBox.Show(
                            $"El campo {campo.Hint} debe ser número",
                            "Error de acceso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                }

            }

            return true;



        }
        public static bool ElNumeroEsTexto(string numero)
        {
            foreach (char texto in numero)
            {
                if (!char.IsNumber(texto))
                {
                    return false;
                }
            }
            return true;
        }


        #endregion
        #region Funcion Es Texto 
        public static bool EsTexto(Object[] campos)
        {
            bool vacios = false;
            for (int i = 0; i < campos.Length; i++)

            {
                MaterialTextBox2 campo = (MaterialTextBox2)campos[i];
                if (!ElTextoEsNumero(campo.Text))
                {
                    MessageBox.Show($"El campo {campo.Hint} tienen caracteres o números");
                    vacios = true;
                    break;
                }

            }
            return vacios;
        }

        public static bool ElTextoEsNumero(string parametro)
        {
            string Abecedario = "qwertyuiopasdfghjklñzxcvbnm ";
            string letraParametro = "";
            string letraAbecedario = "";
            bool esLetra=false;
            for (int i = 0; i < parametro.Length; i++)
            {
                esLetra = false;
                letraParametro = parametro.Substring(i, 1);
                for (int j = 0; j < Abecedario.Length; j++)
                {
                    letraAbecedario= Abecedario.Substring(j, 1);
                    if (letraAbecedario.ToUpper() == letraParametro.ToUpper())
                    {
                        esLetra = true;
                        break;
                    }
                }
                if (!esLetra)
                {
                    return false;
                }

            }
            return true;



        }
        #endregion}
        #region Funcion Palabras Mayor a 3 letras
        public static bool MayorTresLetras(object[] campos)
        {
            bool vacios = false;
            for (int i = 0; i < campos.Length; i++)

            {
                MaterialTextBox2 campo = (MaterialTextBox2)campos[i];
                if (campo.Text.Length < 3)
                {
                    MessageBox.Show($"El campo {campo.Hint} debe de ser mayor de tres letras");
                    vacios = true;
                    break;
                }
            }
            return vacios;
        }
        #endregion
        #region Funcion Numero de Telefono = 8
        public static bool DigitosTelefono(object[] campos)
        {
            bool vacios = false;
            for (int i = 0; i < campos.Length; i++)

            {
                MaterialTextBox2 campo = (MaterialTextBox2)campos[i];
                if (campo.Text.Length != 8)
                {
                    MessageBox.Show($"El campo {campo.Hint} debe de ser de 8 digitos");
                    vacios = true;
                    break;
                }
            }
            return vacios;
        }
        #endregion
        #region Funcion Numero de cedula = 9
        public static bool NumeroCedula(object[] campos)
        {
            bool vacios = false;
            for (int i = 0; i < campos.Length; i++)

            {
                MaterialTextBox2 campo = (MaterialTextBox2)campos[i];
                if (campo.Text.Length != 9)
                {
                    MessageBox.Show($"El campo {campo.Hint} debe de ser de 9 digitos");
                    vacios = true;
                    break;
                }
            }
            return vacios;
        }
        #endregion
        #region Funcion Es Email
        public static bool EsEmail(string correo)
        {
            string letra;
            string dominio = "";
            bool buscaArroba = false;
            string cuerpo = "";
            for (int i = 0; i < correo.Length; i++)
            {

                letra = correo.Substring(i, 1);
                if ((letra == "@" && cuerpo.Length > 2) || buscaArroba)
                {
                    dominio += letra;
                    buscaArroba = true;
                }
                else
                {
                    cuerpo += letra;
                }
            }
            if (dominio == "@gmail.com")
            {
                return true;
            }
            else
            {
                MessageBox.Show($"La estructura de email es incorrecta");
                return false;
            }
        }
        #endregion
        #region Funcion Validar Pago
        public static bool PagoReservacion(string reservacionId, string monto)
        {

            double montoAPagar = Convert.ToDouble(monto);
            double montoPendiente = 0.0;

            if (montoAPagar > 0)
            {

                montoPendiente = precioPorNoche(reservacionId) - SumaPagos(reservacionId);

                if (montoPendiente > 0)
                {
                    if (montoAPagar<=montoPendiente)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"El pago excede el precio ");

                        return false;
                    }

                }
                else
                {
                    MessageBox.Show($"La cuenta ya está pagada ");

                    return false;
                }
            }
            else
            {
                MessageBox.Show("El pago no puede ser menor a 0");
                return false;
            }
        }

        public static double SumaPagos(string reservacionId)
        {
            double montos = 0.0;
            for (int i = 0; i < listPago.Count; i++)
            {
                if (listPago[i].ReservaId == reservacionId)
                {
                    montos += listPago[i].Monto;
                }
            }

            return montos;
        }


        public static double precioPorNoche(string reservacionId)
        {
            string HabitacionId = "";
            double precioPorNoche = 0.0;
            for (int i = 0; i < listReservacion.Count; i++)
            {
                if (listReservacion[i].Id == reservacionId)
                {
                    HabitacionId = listReservacion[i].HabitacionId;
                  
                    break;
                }

            }
            for (int i = 0; i < listHabitaciones.Count; i++)
            {
                if (listHabitaciones[i].Numero == HabitacionId)
                {
                    precioPorNoche = listHabitaciones[i].PrecioPorNoche;
                  
                    break;
                }

            }
            return precioPorNoche;
        }

#endregion

        // Funciones de existencias

        #region Funcion Existe Habitacion
public static bool ExisteHabitacion(string parametro)
        {
            bool Existe = false;
            for (int i = 0; i < listHabitaciones.Count; i++)

            {
                if (listHabitaciones[i].HabitacionId == parametro)
                {
                    Existe = true;

                    break;
                }

            }
            return Existe;
        }
        #endregion
        #region Funcion Existe Reservacion
        public static bool ExisteReservacion(string parametro)
        {
            bool Existe = false;
            for (int i = 0; i < listReservacion.Count; i++)

            {
                if (listReservacion[i].Id == parametro)
                {
                    Existe = true;
                    break;
                }

            }
            return Existe;
        }
        #endregion
        #region Funcion Existe Cliente
        public static bool ExisteCliente(string parametro)
        {
            bool Existe = false;
            for (int i = 0; i < listClientes.Count; i++)

            {
                if (listClientes[i].Id == parametro)
                {
                    Existe = true;

                    break;
                }

            }
            return Existe;
        }
        #endregion
        #region Funcion Existe Pago
        public static bool ExistePago(string parametro)
        {
            bool Existe = false;
            for (int i = 0; i < listPago.Count; i++)

            {
                if ("" + listPago[i].Id == parametro)
                {
                    Existe = true;

                    break;
                }

            }
            return Existe;
        }
        #endregion
        #region Funcion Existe Factura
        public static bool ExisteFactura(string parametro)
        {
            bool Existe = false;
            for (int i = 0; i < listFactura.Count; i++)

            {
                if (""+listFactura[i].Id == parametro)
                {
                    Existe = true;

                    break;
                }

            }
            return Existe;
        }
        #endregion
        #region Funcion Existe Empleado
        public static bool ExisteEmpleado(string parametro)
        {
            bool Existe = false;
            for (int i = 0; i < listEmpleado.Count; i++)

            {
                if (listEmpleado[i].Id == parametro)
                {
                    Existe = true;

                    break;
                }

            }
            return Existe;
        }
        #endregion
        #region Funcion Existe Reservacion en Factura
        public static bool ExisteReservacionFactura(string parametro)
        {
            bool Existe = false;
            for (int i = 0; i < listFactura.Count; i++)

            {
                if (listFactura[i].ReservaId == parametro)
                {
                    Existe = true;

                    break;
                }

            }
            return Existe;
        }
        #endregion


    }
}
