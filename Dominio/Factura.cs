using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Factura
    {
        public int facturaID { get; set; }
        public String reservaID { get; set; }
        [ForeignKey("reservaID")]

        public DateTime fecha { get; set; }

        public String modoPagoID { get; set; }
        [ForeignKey("modoPagoID")]

    }
}
