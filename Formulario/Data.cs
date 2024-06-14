using Las_Amapolas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Las_Amapolas.Formulario
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }


        private void Data_Load(object sender, EventArgs e)
        {
            if (Las_Amapolas.Campo == "habitacion")
            {
                lblBuscar.Text += Las_Amapolas.Campo;

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("Numero", "Numero");
                dataGridView1.Columns.Add("Tipo", "Tipo");
                dataGridView1.Columns.Add("Capacidad", "Capacidad");
                dataGridView1.Columns.Add("Precio por noche", "Precio por noche");
                dataGridView1.Columns.Add("HotelId", "HotelId");
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
            }
            else if (Las_Amapolas.Campo == "pago")
            {
                lblBuscar.Text += Las_Amapolas.Campo;

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("ReservaId", "ReservaId");
                dataGridView1.Columns.Add("Monto", "Monto");
                dataGridView1.Columns.Add("FechaPago", "FechaPago");
                dataGridView1.Columns.Add("MetodoPago", "MetodoPago");
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
            }
            else if (Las_Amapolas.Campo == "empleado")
            {
                lblBuscar.Text += Las_Amapolas.Campo;

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("Apellido", "Apellido");
                dataGridView1.Columns.Add("Nombre", "Nombre");
                dataGridView1.Columns.Add("Posicion", "Posicion");
                dataGridView1.Columns.Add("Email", "Email");
                dataGridView1.Columns.Add("Telefono", "Telefono");

            }

        }
    }
}
