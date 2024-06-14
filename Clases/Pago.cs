using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_Amapolas.Clases
{
    public class Pago
    {
        public int Id { get; set; }
        public string ReservaId { get; set; }
        public double Monto { get; set; }
        public string FechaPago { get; set; }
        public string MetodoPago { get; set; }
    public Pago(int Id_p, string ReservaId_p, double Monto_p, string FechaPago_p, string MetodoPago_p)
    {

        this.Id = Id_p;
        this.ReservaId = ReservaId_p;
        this.Monto = Monto_p;
        this.FechaPago = FechaPago_p;
        this.MetodoPago = MetodoPago_p;
        
    }

}
}
