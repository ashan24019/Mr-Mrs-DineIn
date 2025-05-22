﻿namespace Mr_and_Mrs_DineIn.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Product> Products { get; set; } // A category can have many products
    }
}