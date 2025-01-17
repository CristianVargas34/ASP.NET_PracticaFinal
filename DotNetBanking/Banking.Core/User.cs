﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Core
{
    public class User : IdentityUser
    {
        public int UserID { get; set; }
        [Required]
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public string Documento_Identidad { get; set; }

        public string Telefono { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }

        public int AccountID { get; set; }
        public virtual Account Account { get; set; }
    }
}
