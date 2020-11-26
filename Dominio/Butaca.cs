using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Butaca
    {
        public int butacaID { get; set; }

        [ForeignKey("aeronaveID")]
        public int aeronaveID { get; set; }

        [ForeignKey("claseViajeID")]
        public int claseViajeID { get; set; }
    
        [ForeignKey("estadoButacaID")]
        public int estadoButacaID { get; set; }
    }
}
