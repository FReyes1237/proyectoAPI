using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Vuelo
    {
        public int vueloID { get; set; }

        [ForeignKey("estadoVueloID")]
        public int estadoVueloID { get; set; }

        [ForeignKey("calendarioID")]
        public int calendarioID { get; set; }
    }
}
