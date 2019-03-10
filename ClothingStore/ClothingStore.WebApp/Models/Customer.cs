﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.WebApp.Models
{
    public class Customer
    {
        [Display(Name = "ID")]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Default Store")]
        public int DefaultStoreId { get; set; }

    }
}