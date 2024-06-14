using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_Amapolas.Clases
{
    public class Hotel
    {
        public string HotelId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public int Estrellas { get; set; }
        public List<Habitación> Habitaciones { get; set; }
        public Hotel(string id_p,string Nombre_p, string Direccion_p, string Ciudad_p,string Pais_p,int Estrellas_p,     List<Habitación> Habitaciones_p =null)
        {

            this.HotelId = id_p;
            this.Nombre = Nombre_p;
            this.Direccion = Direccion_p;
            this.Ciudad = Ciudad_p;
            this.Pais = Pais_p;
            this.Estrellas = Estrellas_p;
            this.Habitaciones = Habitaciones_p;
        }

    }

}
