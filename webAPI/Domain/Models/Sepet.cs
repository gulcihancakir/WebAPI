﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Domain.Models
{
    public class Sepet
    {
        public int Id { get; set; }
        public string Images { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double new_Price { get; set; }

       
    }
}
