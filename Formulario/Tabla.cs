using Las_Amapolas.Clases;
using Las_Amapolas.Formulario.Registrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Las_Amapolas.Formulario
{
    public partial class Tabla : Form
    {
       
        public Tabla()
        {
            InitializeComponent();
        }

        #region Inicializar tablas
        private void Data_Load(object sender, EventArgs e)
        {
            btnLimpiar.Visible = false;
            btnEliminar.Visible = false;
            if (Las_Amapolas.Campo == "habitacion")
            {
                lblBuscar.Text += Las_Amapolas.Campo;

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("Numero", "Numero");
                dataGridView1.Columns.Add("Tipo", "Tipo");
                dataGridView1.Columns.Add("Capacidad", "Capacidad");
                dataGridView1.Columns.Add("Precio por noche", "Precio por noche");
                dataGridView1.Columns.Add("HotelId", "HotelId");
                foreach (Habitación habitaciones in Login.listHabitaciones)
                {
                    dataGridView1.Rows.Add(habitaciones.HabitacionId, habitaciones.Numero, habitaciones.Tipo, habitaciones.Capacidad, habitaciones.PrecioPorNoche, habitaciones.HotelId);

                }

            }
            else if (Las_Amapolas.Campo == "reservación")

            {
                lblBuscar.Text += Las_Amapolas.Campo;

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("ClienteId", "ClienteId");
                dataGridView1.Columns.Add("HabitacionId", "HabitacionId");
                dataGridView1.Columns.Add("FechaInicio", "FechaInicio");
                dataGridView1.Columns.Add("FechaFin", "FechaFin");
                dataGridView1.Columns.Add("Estado", "Estado");
                foreach (Reserva reseracion in Login.listReservacion)
                {
                    dataGridView1.Rows.Add(reseracion.Id, reseracion.ClienteId, reseracion.HabitacionId, reseracion.FechaInicio, reseracion.FechaFin, reseracion.Estado);

                }
            }
            else if (Las_Amapolas.Campo == "cliente")
            {

                lblBuscar.Text += Las_Amapolas.Campo;

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("Nombre", "Nombre");
                dataGridView1.Columns.Add("Apellido", "Apellido");
                dataGridView1.Columns.Add("Email", "Email");
                dataGridView1.Columns.Add("Telefono", "Telefono");
                dataGridView1.Columns.Add("Direccion", "Direccion");
                foreach (Cliente clientes in Login.listClientes)
                {
                    dataGridView1.Rows.Add(clientes.Id, clientes.Nombre, clientes.Apellido, clientes.Email, clientes.Telefono, clientes.Direccion);

                }
            }
            else if (Las_Amapolas.Campo == "pago")
            {
                lblBuscar.Text += Las_Amapolas.Campo;

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("ReservaId", "ReservaId");
                dataGridView1.Columns.Add("Monto", "Monto");
                dataGridView1.Columns.Add("FechaPago", "FechaPago");
                dataGridView1.Columns.Add("MetodoPago", "MetodoPago");
                foreach (Pago pagos in Login.listPago)
                {
                    dataGridView1.Rows.Add(pagos.Id, pagos.ReservaId, pagos.Monto, pagos.FechaPago, pagos.MetodoPago);

                }
            }
            else if (Las_Amapolas.Campo == "factura")
            {
                lblBuscar.Text += Las_Amapolas.Campo;

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("ReservaId", "ReservaId");
                dataGridView1.Columns.Add("ClienteId", "ClienteId");
                dataGridView1.Columns.Add("EmpleadoId", "EmpleadoId");
                dataGridView1.Columns.Add("MontoTotal", "MontoTotal");
                dataGridView1.Columns.Add("FechaEmision", "FechaEmision");
                foreach (Factura facturas in Login.listFactura)
                {
                    dataGridView1.Rows.Add(facturas.Id, facturas.ReservaId, facturas.ClienteId, facturas.EmpleadoId, facturas.MontoTotal, facturas.FechaEmision);

                }
            }
            else if (Las_Amapolas.Campo == "empleado")
            {
                lblBuscar.Text += Las_Amapolas.Campo;

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("Nombre", "Nombre");
                dataGridView1.Columns.Add("Apellido", "Apellido");
                dataGridView1.Columns.Add("Email", "Email");
                dataGridView1.Columns.Add("Teléfono", "Teléfono");
                dataGridView1.Columns.Add("Posicion", "Posicion");

                foreach (Empleado empleados in Login.listEmpleado)
                {
                    dataGridView1.Rows.Add(empleados.Id, empleados.Nombre, empleados.Apellido, empleados.Email, empleados.Telefono, empleados.Posicion);

                }

            }

        }
        #endregion

        #region Boton de Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Login.EsNumero(new object[] { txtIdBuscar }))
            {
                if (Las_Amapolas.Campo == "habitacion")
                {
                    if (Login.ExisteHabitacion(txtIdBuscar.Text))
                    {
                        buscarHabitacion(txtIdBuscar.Text);
                        
                    }
                    else
                    {
                        MessageBox.Show($"La habitación {txtIdBuscar.Text} no existe");
                    }

                }
                else if (Las_Amapolas.Campo == "reservación")

                {

                    if (Login.ExisteReservacion(txtIdBuscar.Text))

                    {
                        buscarReservacion(txtIdBuscar.Text);
                        
                    }
                    else
                    {
                        MessageBox.Show($"La reservación {txtIdBuscar.Text} no existe");
                    }
                }

                else if (Las_Amapolas.Campo == "cliente")
                {
                    if (Login.ExisteCliente(txtIdBuscar.Text))

                    {
                        buscarCliente(txtIdBuscar.Text);
                       
                    }
                    else
                    {
                        MessageBox.Show($"El cliente {txtIdBuscar.Text} no existe");
                    }
                }
                else if (Las_Amapolas.Campo == "pago")
                {
                    if (Login.ExistePago(txtIdBuscar.Text))

                    {
                        buscarPago(txtIdBuscar.Text);
                        
                    }
                    else
                    {
                        MessageBox.Show($"El pago {txtIdBuscar.Text} no existe");
                    }

                }
                else if (Las_Amapolas.Campo == "factura")
                {
                    if (Login.ExisteFactura(txtIdBuscar.Text))

                    {
                        buscarFactura(txtIdBuscar.Text);
                        
                    }
                    else
                    {
                        MessageBox.Show($"La factura {txtIdBuscar.Text} no existe");
                    }
                }
                else if (Las_Amapolas.Campo == "empleado")
                {
                    if (Login.ExisteEmpleado(txtIdBuscar.Text))

                    {
                        buscarEmpleado(txtIdBuscar.Text);
                        
                    }
                    else
                    {
                        MessageBox.Show($"El empleado {txtIdBuscar.Text} no existe");
                    }
                }

            }


        }
        #endregion

        #region Boton de Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Las_Amapolas.Campo == "habitacion")
            {
                if (Login.ExisteHabitacion(txtIdBuscar.Text))
                {
                    EliminarHabitacion(txtIdBuscar.Text);
                }
                else
                {
                    MessageBox.Show($"La habitación {txtIdBuscar.Text} no existe");
                }
            }
            else if (Las_Amapolas.Campo == "reservación")
            {

                if (Login.ExisteReservacion(txtIdBuscar.Text))
                {
                    EliminarReservacion(txtIdBuscar.Text);
                }
                else
                {
                    MessageBox.Show($"La reservación {txtIdBuscar.Text} no existe");
                }
            }
            else if (Las_Amapolas.Campo == "cliente")
            {

                if (Login.ExisteCliente(txtIdBuscar.Text))
                {
                    EliminarCliente(txtIdBuscar.Text);
                }
                else
                {
                    MessageBox.Show($"El cliente {txtIdBuscar.Text} no existe");
                }
            }
            else if (Las_Amapolas.Campo == "pago")
            {

                if (Login.ExistePago(txtIdBuscar.Text))
                {
                    EliminarPago(txtIdBuscar.Text);
                }
                else
                {
                    MessageBox.Show($"El pago {txtIdBuscar.Text} no existe");
                }
            }
            else if (Las_Amapolas.Campo == "factura")
            {
                if (Login.ExisteFactura(txtIdBuscar.Text))
                {
                    EliminarFactura(txtIdBuscar.Text);
                }
                else
                {
                    MessageBox.Show($"La factura {txtIdBuscar.Text} no existe");
                }
            }
            else if (Las_Amapolas.Campo == "empleado")
            {
                if (Login.ExisteEmpleado(txtIdBuscar.Text))
                {
                    EliminarEmpleado(txtIdBuscar.Text);
                }
                else
                {
                    MessageBox.Show($"El empleado {txtIdBuscar.Text} no existe");
                }
            }
        }
        #endregion

        #region Visibilidad de botones
        private void txtIdBuscar_TextChanged(object sender, EventArgs e)
        {

            if (Las_Amapolas.Campo == "habitacion")
            {

                if (Login.ExisteHabitacion(txtIdBuscar.Text))

                {
                    btnLimpiar.Visible = true;
                    btnEliminar.Visible = true;
                  
                }
                else
                {
                    btnLimpiar.Visible = false;
                    btnEliminar.Visible = false;
                    
                }



            }
            else if (Las_Amapolas.Campo == "reservación")

            {

                if (Login.ExisteReservacion(txtIdBuscar.Text))

                {
                    btnLimpiar.Visible = true;
                    btnEliminar.Visible = true;
                }
                else
                {
                    btnLimpiar.Visible = false;
                    btnEliminar.Visible = false;
                }
            }

            else if (Las_Amapolas.Campo == "cliente")
            {
                if (Login.ExisteCliente(txtIdBuscar.Text))

                {
                    btnLimpiar.Visible = true;
                    btnEliminar.Visible = true;
                }
                else
                {
                    btnLimpiar.Visible = false;
                    btnEliminar.Visible = false;
                }
            }
            else if (Las_Amapolas.Campo == "pago")
            {
                if (Login.ExistePago(txtIdBuscar.Text))

                {
                    btnLimpiar.Visible = true;
                    btnEliminar.Visible = true;
                }
                else
                {
                    btnLimpiar.Visible = false;
                    btnEliminar.Visible = false;
                }

            }
            else if (Las_Amapolas.Campo == "factura")
            {
                if (Login.ExisteFactura(txtIdBuscar.Text))

                {
                    btnLimpiar.Visible = true;
                    btnEliminar.Visible = true;
                }
                else
                {
                    btnLimpiar.Visible = false;
                    btnEliminar.Visible = false;
                }
            }
            else if (Las_Amapolas.Campo == "empleado")
            {
                if (Login.ExisteEmpleado(txtIdBuscar.Text))

                {
                    btnLimpiar.Visible = true;
                    btnEliminar.Visible = true;

                }
                else
                {
                    btnLimpiar.Visible = false;
                    btnEliminar.Visible = false;
                }
            }
        }
        #endregion


        #region Funcion Buscar Habitacion
        private void buscarHabitacion(string HabitacionId_p)
        {
            string espacio1 = "";
            string espacio2 = "";
            string espacio3 = "";
            string espacio4 = "";
            string espacio5 = "";
            string espacio6 = "";

            espacio1 = Login.listHabitaciones[0].HabitacionId;
            espacio2 = Login.listHabitaciones[0].Numero;
            espacio3 = Login.listHabitaciones[0].Tipo;
            espacio4 = "" + Login.listHabitaciones[0].PrecioPorNoche;
            espacio5 = "" + Login.listHabitaciones[0].Capacidad;
            espacio6 = Login.listHabitaciones[0].HotelId;

            for (int i = 0; i < Login.listHabitaciones.Count; i++)
            {
                if (HabitacionId_p == Login.listHabitaciones[i].HabitacionId)
                {
                    Login.listHabitaciones[0].HabitacionId = Login.listHabitaciones[i].HabitacionId;
                    Login.listHabitaciones[0].Numero = Login.listHabitaciones[i].Numero;
                    Login.listHabitaciones[0].Tipo = Login.listHabitaciones[i].Tipo;
                    Login.listHabitaciones[0].PrecioPorNoche = Login.listHabitaciones[i].PrecioPorNoche;
                    Login.listHabitaciones[0].Capacidad = Login.listHabitaciones[i].Capacidad;
                    Login.listHabitaciones[0].HotelId = Login.listHabitaciones[i].HotelId;

                    Login.listHabitaciones[i].HabitacionId = espacio1;
                    Login.listHabitaciones[i].Numero = espacio2;
                    Login.listHabitaciones[i].Tipo = espacio3;
                    Login.listHabitaciones[i].PrecioPorNoche = Convert.ToDouble(espacio4);
                    Login.listHabitaciones[i].Capacidad = Convert.ToInt32(espacio5);
                    Login.listHabitaciones[i].HotelId = espacio6;

                }
            }

            dataGridView1.Rows.Clear();

            foreach (Habitación habitaciones in Login.listHabitaciones)
            {
                dataGridView1.Rows.Add(habitaciones.HabitacionId, habitaciones.Numero, habitaciones.Tipo, habitaciones.Capacidad, habitaciones.PrecioPorNoche, habitaciones.HotelId);

            }


        }
        #endregion

        #region Funcion Buscar Reservacion
        private void buscarReservacion(string ReservacionId_p)
        {
            string espacio1 = "";
            string espacio2 = "";
            string espacio3 = "";
            string espacio4 = "";
            string espacio5 = "";
            string espacio6 = "";

            espacio1 = Login.listReservacion[0].Id;
            espacio2 = Login.listReservacion[0].ClienteId;
            espacio3 = Login.listReservacion[0].HabitacionId;
            espacio4 = "" + Login.listReservacion[0].FechaInicio;
            espacio5 = "" + Login.listReservacion[0].FechaFin;
            espacio6 = Login.listReservacion[0].Estado;

            for (int i = 0; i < Login.listReservacion.Count; i++)
            {
                if (ReservacionId_p == Login.listReservacion[i].Id)
                {
                    Login.listReservacion[0].Id = Login.listReservacion[i].Id;
                    Login.listReservacion[0].ClienteId = Login.listReservacion[i].ClienteId;
                    Login.listReservacion[0].HabitacionId = Login.listReservacion[i].HabitacionId;
                    Login.listReservacion[0].FechaInicio = Login.listReservacion[i].FechaInicio;
                    Login.listReservacion[0].FechaFin = Login.listReservacion[i].FechaFin;
                    Login.listReservacion[0].Estado = Login.listReservacion[i].Estado;

                    Login.listReservacion[i].Id = espacio1;
                    Login.listReservacion[i].ClienteId = espacio2;
                    Login.listReservacion[i].HabitacionId = espacio3;
                    Login.listReservacion[i].FechaInicio = espacio4;
                    Login.listReservacion[i].FechaFin = espacio5;
                    Login.listReservacion[i].Estado = espacio6;

                }
            }
            dataGridView1.Rows.Clear();

            foreach (Reserva reseracion in Login.listReservacion)
            {
                dataGridView1.Rows.Add(reseracion.Id, reseracion.ClienteId, reseracion.HabitacionId, reseracion.FechaInicio, reseracion.FechaFin, reseracion.Estado);

            }

        }
        #endregion

        #region Funcion Buscar Cliente
        private void buscarCliente(string Cliente_p)
        {
            string espacio1 = "";
            string espacio2 = "";
            string espacio3 = "";
            string espacio4 = "";
            int espacio5 = 0;
            string espacio6 = "";


            espacio1 = Login.listClientes[0].Id;
            espacio2 = Login.listClientes[0].Nombre;
            espacio3 = Login.listClientes[0].Apellido;
            espacio4 = "" + Login.listClientes[0].Email;
            espacio5 = Login.listClientes[0].Telefono;
            espacio6 = Login.listClientes[0].Direccion;

            for (int i = 0; i < Login.listClientes.Count; i++)
            {
                if (Cliente_p == Login.listClientes[i].Id)
                {
                    Login.listClientes[0].Id = Login.listClientes[i].Id;
                    Login.listClientes[0].Nombre = Login.listClientes[i].Nombre;
                    Login.listClientes[0].Apellido = Login.listClientes[i].Apellido;
                    Login.listClientes[0].Email = Login.listClientes[i].Email;
                    Login.listClientes[0].Telefono = Login.listClientes[i].Telefono;
                    Login.listClientes[0].Direccion = Login.listClientes[i].Direccion;

                    Login.listClientes[i].Id = espacio1;
                    Login.listClientes[i].Nombre = espacio2;
                    Login.listClientes[i].Apellido = espacio3;
                    Login.listClientes[i].Email = espacio4;
                    Login.listClientes[i].Telefono = espacio5;
                    Login.listClientes[i].Direccion = espacio6;

                }
            }


            dataGridView1.Rows.Clear();

            foreach (Cliente clientes in Login.listClientes)
            {
                dataGridView1.Rows.Add(clientes.Id, clientes.Nombre, clientes.Apellido, clientes.Email, clientes.Telefono, clientes.Direccion);

            }

        }
        #endregion

        #region Funcion Buscar Pago
        private void buscarPago(string Pago_p)
        {
            int espacio1 = 0;
            string espacio2 = "";
            double espacio3 = 0;
            string espacio4 = "";
            string espacio5 = "";

            espacio1 = Login.listPago[0].Id;
            espacio2 = Login.listPago[0].ReservaId;
            espacio3 = Login.listPago[0].Monto;
            espacio4 = "" + Login.listPago[0].FechaPago;
            espacio5 = "" + Login.listPago[0].MetodoPago;

            for (int i = 0; i < Login.listPago.Count; i++)
            {
                if (Pago_p == "" + Login.listPago[i].Id)
                {
                    Login.listPago[0].Id = Login.listPago[i].Id;
                    Login.listPago[0].ReservaId = Login.listPago[i].ReservaId;
                    Login.listPago[0].Monto = Login.listPago[i].Monto;
                    Login.listPago[0].FechaPago = Login.listPago[i].FechaPago;
                    Login.listPago[0].MetodoPago = Login.listPago[i].MetodoPago;


                    Login.listPago[i].Id = espacio1;
                    Login.listPago[i].ReservaId = espacio2;
                    Login.listPago[i].Monto = espacio3;
                    Login.listPago[i].FechaPago = espacio4;
                    Login.listPago[i].MetodoPago = espacio5;

                }
            }

            dataGridView1.Rows.Clear();

            foreach (Pago pagos in Login.listPago)
            {
                dataGridView1.Rows.Add(pagos.Id, pagos.ReservaId, pagos.Monto, pagos.FechaPago, pagos.MetodoPago);

            }

        }

        #endregion

        #region Funcion Buscar Factura
        private void buscarFactura(string Factura_p)
        {
            int espacio1 = 0;
            string espacio2 = "";
            string espacio3 = "";
            string espacio4 = "";
            double espacio5 = 0;
            string espacio6 = "";

            espacio1 = Login.listFactura[0].Id;
            espacio2 = Login.listFactura[0].ReservaId;
            espacio3 = Login.listFactura[0].ClienteId;
            espacio4 = "" + Login.listFactura[0].EmpleadoId;
            espacio5 = Login.listFactura[0].MontoTotal;
            espacio6 = Login.listFactura[0].FechaEmision;

            for (int i = 0; i < Login.listFactura.Count; i++)
            {
                if (Factura_p == "" + Login.listFactura[i].Id)
                {
                    Login.listFactura[0].Id = Login.listFactura[i].Id;
                    Login.listFactura[0].ReservaId = Login.listFactura[i].ReservaId;
                    Login.listFactura[0].ClienteId = Login.listFactura[i].ClienteId;
                    Login.listFactura[0].EmpleadoId = Login.listFactura[i].EmpleadoId;
                    Login.listFactura[0].MontoTotal = Login.listFactura[i].MontoTotal;
                    Login.listFactura[0].FechaEmision = Login.listFactura[i].FechaEmision;

                    Login.listFactura[i].Id = espacio1;
                    Login.listFactura[i].ReservaId = espacio2;
                    Login.listFactura[i].ClienteId = espacio3;
                    Login.listFactura[i].EmpleadoId = espacio4;
                    Login.listFactura[i].MontoTotal = espacio5;
                    Login.listFactura[i].FechaEmision = espacio6;

                }
            }

            dataGridView1.Rows.Clear();

            foreach (Factura facturas in Login.listFactura)
            {
                dataGridView1.Rows.Add(facturas.Id, facturas.ReservaId, facturas.ClienteId, facturas.EmpleadoId, facturas.MontoTotal, facturas.FechaEmision);

            }

        }
        #endregion

        #region Funcion Buscar Empleado
        private void buscarEmpleado(string Empleado_p)
        {
            string espacio1 = "";
            string espacio2 = "";
            string espacio3 = "";
            string espacio4 = "";
            int espacio5 = 0;
            string espacio6 = "";


            espacio1 = Login.listEmpleado[0].Id;
            espacio2 = Login.listEmpleado[0].Nombre;
            espacio3 = Login.listEmpleado[0].Apellido;
            espacio4 = "" + Login.listEmpleado[0].Email;
            espacio5 = Login.listEmpleado[0].Telefono;
            espacio6 = Login.listEmpleado[0].Posicion;

            for (int i = 0; i < Login.listEmpleado.Count; i++)
            {
                if (Empleado_p == Login.listEmpleado[i].Id)
                {
                    Login.listEmpleado[0].Id = Login.listEmpleado[i].Id;
                    Login.listEmpleado[0].Nombre = Login.listEmpleado[i].Nombre;
                    Login.listEmpleado[0].Apellido = Login.listEmpleado[i].Apellido;
                    Login.listEmpleado[0].Email = Login.listEmpleado[i].Email;
                    Login.listEmpleado[0].Telefono = Login.listEmpleado[i].Telefono;
                    Login.listEmpleado[0].Posicion = Login.listEmpleado[i].Posicion;

                    Login.listEmpleado[i].Id = espacio1;
                    Login.listEmpleado[i].Nombre = espacio2;
                    Login.listEmpleado[i].Apellido = espacio3;
                    Login.listEmpleado[i].Email = espacio4;
                    Login.listEmpleado[i].Telefono = espacio5;
                    Login.listEmpleado[i].Posicion = espacio6;

                }
            }

            dataGridView1.Rows.Clear();

            foreach (Empleado empleados in Login.listEmpleado)
            {
                dataGridView1.Rows.Add(empleados.Id, empleados.Nombre, empleados.Apellido, empleados.Email, empleados.Telefono, empleados.Posicion);

            }

        }
        #endregion

        #region Funciones Para Eliminar
        private void EliminarHabitacion(string HabitacionId)

        {

            for (int i = 0; i < Login.listHabitaciones.Count; i++)
            {
                if (HabitacionId == Login.listHabitaciones[i].HabitacionId)
                {
                    Login.listHabitaciones.RemoveAt(i);
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            foreach (Habitación habitaciones in Login.listHabitaciones)
            {
                dataGridView1.Rows.Add(habitaciones.HabitacionId, habitaciones.Numero, habitaciones.Tipo, habitaciones.Capacidad, habitaciones.PrecioPorNoche, habitaciones.HotelId);

            }

        }

        private void EliminarReservacion(string ReservacionId)

        {

            for (int i = 0; i < Login.listReservacion.Count; i++)
            {
                if (ReservacionId == Login.listReservacion[i].Id)
                {
                    Login.listReservacion.RemoveAt(i);
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            foreach (Reserva reseracion in Login.listReservacion)
            {
                dataGridView1.Rows.Add(reseracion.Id, reseracion.ClienteId, reseracion.HabitacionId, reseracion.FechaInicio, reseracion.FechaFin, reseracion.Estado);

            }

        }

        private void EliminarCliente(string ClienteId)

        {

            for (int i = 0; i < Login.listClientes.Count; i++)
            {
                if (ClienteId == Login.listClientes[i].Id)
                {
                    Login.listClientes.RemoveAt(i);
                    break;
                }
            }
            dataGridView1.Rows.Clear();

            foreach (Cliente clientes in Login.listClientes)
            {
                dataGridView1.Rows.Add(clientes.Id, clientes.Nombre, clientes.Apellido, clientes.Email, clientes.Telefono, clientes.Direccion);

            }
        }

        private void EliminarPago(string PagoId)

        {

            for (int i = 0; i < Login.listPago.Count; i++)
            {
                if (PagoId == "" + Login.listPago[i].Id)
                {
                    Login.listPago.RemoveAt(i);
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            foreach (Pago pagos in Login.listPago)
            {
                dataGridView1.Rows.Add(pagos.Id, pagos.ReservaId, pagos.Monto, pagos.FechaPago, pagos.MetodoPago);

            }

        }

        private void EliminarFactura(string FacturaId)

        {

            for (int i = 0; i < Login.listFactura.Count; i++)
            {
                if (FacturaId == "" + Login.listFactura[i].Id)
                {
                    Login.listFactura.RemoveAt(i);
                    break;
                }
            }
            dataGridView1.Rows.Clear();

            foreach (Factura facturas in Login.listFactura)
            {
                dataGridView1.Rows.Add(facturas.Id, facturas.ReservaId, facturas.ClienteId, facturas.EmpleadoId, facturas.MontoTotal, facturas.FechaEmision);

            }

        }
        private void EliminarEmpleado(string EmpleadoId)

        {

            for (int i = 0; i < Login.listEmpleado.Count; i++)
            {
                if (EmpleadoId == "" + Login.listEmpleado[i].Id)
                {
                    Login.listEmpleado.RemoveAt(i);
                    break;
                }
            }
            dataGridView1.Rows.Clear();

            foreach (Empleado empleados in Login.listEmpleado)
            {
                dataGridView1.Rows.Add(empleados.Id, empleados.Nombre, empleados.Apellido, empleados.Email, empleados.Telefono, empleados.Posicion);

            }

        }

        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdBuscar.Text = "";
        }
    }

}
