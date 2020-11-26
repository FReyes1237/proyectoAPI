using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class precioButaca
    {
        public int precioButacaID { get; set; }

        public float precio { get; set; }

        [ForeignKey("claseViajeID")]
        public int claseViajeID { get; set; }
        
        [ForeignKey("vueloID")]
        public int vueloID { get; set; }
    }
}
