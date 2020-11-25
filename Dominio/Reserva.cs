using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Reserva
    {
        public int reservaID { get; set; }
        public String Username { get; set; }
        [ForeignKey("Username")]
        public String vueloID { get; set; }
        [ForeignKey("vueloID")]
        public int butacaID { get; set; }
        public float precio { get; set; }

    }
}
