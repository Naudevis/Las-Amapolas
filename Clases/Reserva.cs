using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_Amapolas.Clases
{
    public class Reserva
    {
        public string Id { get; set; }
        public string ClienteId { get; set; }
        public string HabitacionId { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Estado { get; set; }
        public Reserva(string Id_p, string ClienteId_p, string HabitacionId_p, string FechaInicio_p, string FechaFin_p, string Estado_p)
        {

            this.Id = Id_p;
            this.ClienteId = ClienteId_p;
            this.HabitacionId = HabitacionId_p;
            this.FechaInicio = FechaInicio_p;
            this.FechaFin = FechaFin_p;
            this.Estado = Estado_p;
        }

    }
}
