using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_Amapolas.Clases
{
    internal class Cliente
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public Cliente(string Id_p, string Nombre_p, string Apellido_p, string Email_p, int Telefono_p, string Direccion_p)
        {

            this.Id = Id_p;
            this.Nombre = Nombre_p;
            this.Apellido = Apellido_p;
            this.Email = Email_p;
            this.Telefono = Telefono_p;
            this.Direccion = Direccion_p;
        }

    }
}
