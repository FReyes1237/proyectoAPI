using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Dominio
{
    public class Cliente : IdentityUser
    {
		public int  ClienteID { get; set; }

		public String Nombre { get; set; }

		public String Apellido { get; set; }

		public String Telefono { get; set; }

		public String Email { get; set; }

		public String Pasaporte { get; set; }

		[ForeignKey("paisID")]

		public int UserID { get; set; }

		[ForeignKey("UserID")]

		public int paisID { get; set; }
	}
}
