﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations
{
    public class Customer
    {
       
        public int Id { get; set; }

       [Required, StringLenght(5)] 
        public string Name { get; set; }
        public string Model { get; set; }

        public int Hp { get; set; }
        public int Year { get; set; }
        public string Engine { get; set; }


    }
}
