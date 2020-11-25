using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Aeropuerto
    {
        public int aeropuertoID { get; set; }

        public String nombreAeropuerto { get; set; }

        public int ciudadID { get; set; }
        [ForeignKey("ciudadID")]

    }
}
