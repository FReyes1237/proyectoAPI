using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Ciudad
    {
        public int ciudadID { get; set; }
        public String nombreCiudad { get; set; }
        public int paisID { get; set; }
        [ForeignKey("paisID")]
    }
}
