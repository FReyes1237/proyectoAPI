using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Calendario
    {
        public int calendarioID { get; set; }

        [ForeignKey("aeropuertoID")]
        public int iDAeropuertoOrigen { get; set; }

        [ForeignKey("aeropuertoID")]
        public int iDAeropuertoDestino { get; set; }
        public DateTime horaSalida { get; set; }
        public DateTime horaLlegada { get; set; }
    }
}
