using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Usuario
    {
		public String Username { get; set; }

		public String Nombre { get; set; }

		public String Apellido { get; set; }

		public String Telefono { get; set; }

		public String Email { get; set; }

		public String Pasaporte { get; set; }

		[ForeignKey("paisID")]
		public int paisID { get; set; }
	}
}
