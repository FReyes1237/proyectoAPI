using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Reserva
    {
        public int reservaID { get; set; }

        [ForeignKey("ClienteID")]
        public int ClienteID { get; set; }

        public int butacaID { get; set; }
    }
}
