using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Vuelo
    {
        public int vueloID { get; set; }
        public int estadoVueloID { get; set; }
        [ForeignKey("estadoVueloID")]
        public int calendarioID { get; set; }
        [ForeignKey("calendarioID")]
    }
}
