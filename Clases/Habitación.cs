using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_Amapolas.Clases
{
    public class Habitación
    {
        public string HabitacionId { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public double PrecioPorNoche { get; set; }
        public string HotelId { get; set; }
        public Habitación(string HabitacionId, string Numero_p, string Tipo_p, int Capacidad_p, double PrecioPorNoche_p, string HotelId_p)
        {

            this.HabitacionId = HabitacionId;
            this.Numero = Numero_p;
            this.Tipo = Tipo_p;
            this.Capacidad = Capacidad_p;
            this.PrecioPorNoche = PrecioPorNoche_p;
            this.HotelId = HotelId_p;
        }

    }
}
