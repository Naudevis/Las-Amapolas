using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_Amapolas.Clases
{
    public class Factura
    {
        public int Id { get; set; }
        public string ReservaId { get; set; }
        public string ClienteId { get; set; }
        public string EmpleadoId { get; set; }
        public double MontoTotal { get; set; }
        public string FechaEmision { get; set; }
        public Factura(int Id_p, string ReservaId_p, string Cliente_p, string EmpleadoId_p, double MontoTotal_p, string FechaEmision_p)
        {

            this.Id = Id_p;
            this.ReservaId = ReservaId_p;
            this.ClienteId = Cliente_p;
            this.EmpleadoId = EmpleadoId_p;
            this.MontoTotal = MontoTotal_p;
            this.FechaEmision = FechaEmision_p;
        }

    }
}
