using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Ciudad
    {
        public int ciudadID { get; set; }

        public String nombreCiudad { get; set; }

        [ForeignKey("paisID")]
        public int paisID { get; set; }
        
    }
}
