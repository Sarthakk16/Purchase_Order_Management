﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace POM_trial.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int Id { get; set; }
        [Required]
        public int ShoppingCartId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }   
        public Product Product { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
