using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class precioButaca
    {
        public int precioButacaID { get; set; }
        public float precio { get; set; }
        public int claseViajeID { get; set; }
        [ForeignKey("claseViajeID")]
        public int vueloID { get; set; }
        [ForeignKey("vueloID")]
    }
}
