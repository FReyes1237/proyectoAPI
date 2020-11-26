using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Factura
    {
        public int facturaID { get; set; }

        [ForeignKey("reservaID")]
        public String reservaID { get; set; }
        public DateTime fecha { get; set; }

        [ForeignKey("modoPagoID")]
        public String modoPagoID { get; set; }
    }
}
