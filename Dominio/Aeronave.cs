using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Aeronave
    {
        public int aeronaveID { get; set; }
        public String modelo { get; set; }
    }
}
