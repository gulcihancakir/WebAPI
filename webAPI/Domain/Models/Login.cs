﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Domain.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public string Parola { get; set; }
    }
}
