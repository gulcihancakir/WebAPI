using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Domain.Models
{
    public class Signup
    {
        public int Id {get;set; }
        public string Name{ get; set; }
        public string Surname { get; set; }

        public string Phone_Number { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }

        public string Parola { get; set; }
    }
}
