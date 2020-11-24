using System;
using System.Collections.Generic;

namespace proyectoAPI.Models 
{
	public class Usuario
	{
		public string Username { get; set; }

		public string Nombre { get; set; }

		public string Apellido { get; set; }

		public string Telefono { get; set; }

		public string Email { get; set; }

		public string Pasaporte { get; set; }

		public int paisID { get; set; }
		[ForeignKey("paisID")]

	}

}

