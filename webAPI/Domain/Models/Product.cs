using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public string Price { get; set; }
        public string new_Price { get; set; }

        public string Images { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
