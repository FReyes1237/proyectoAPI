using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Aeropuerto
    {
        public int aeropuertoID { get; set; }

        public String nombreAeropuerto { get; set; }

        [ForeignKey("ciudadID")]
        public int ciudadID { get; set; }
        

    }
}
