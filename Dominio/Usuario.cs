using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Usuario : IdentityUser
    {
        public int UserID { get; set; }

        public String Username { get; set; }

        public String Password { get; set; }

    }
}
