﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace PhoneShopShatedLibrary.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required] 
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required, Range(0.1, 99999.99)]
        public decimal? Price { get; set;}
        [Required, DisplayName("Product Image")]
        public string? Base64Img { get; set; }
        [Required, Range(0, 99999)]
        public int Quantity { get; set; }
        public bool Featured { get; set; } = false;
        public DateTime DateUpLoaded { get; set; } = DateTime.Now;
    }
}
