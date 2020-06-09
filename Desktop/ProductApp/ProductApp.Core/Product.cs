﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Core
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(length:100)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        public bool InStock { get; set; }
    }
}
