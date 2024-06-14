using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_Amapolas.Clases
{
    internal class Factura
    {
        public int Id { get; set; }
        public string ReservaId { get; set; }
        public string Cliente { get; set; }
        public string EmpleadoId { get; set; }
        public string MontoTotal { get; set; }
        public int FechaEmision { get; set; }
        public Factura(int Id_p, string ReservaId_p, string Cliente_p, string EmpleadoId_p, string MontoTotal_p, int FechaEmision_p)
        {

            this.Id = Id_p;
            this.ReservaId = ReservaId_p;
            this.Cliente = Cliente_p;
            this.EmpleadoId = EmpleadoId_p;
            this.MontoTotal = MontoTotal_p;
            this.FechaEmision = FechaEmision_p;
        }

    }
}
