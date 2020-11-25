using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Butaca
    {
        public int butacaID { get; set; }
        public int aeronaveID { get; set; }
        public int claseViajeID { get; set; }
        [ForeignKey("claseViajeID")]
        public int estadoButacaID { get; set; }
        [ForeignKey("estadoButacaID")]

    }
}
