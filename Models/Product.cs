using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Mr_and_Mrs_DineIn.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; } // For file upload
        public string ImageUrl { get; set; } = "https://via.placeholder.com/150"; // Default image URL

        [ValidateNever]
        public Category? Category { get; set; } // A product belongs to a category

        [ValidateNever]
        public ICollection<OrderItem>? OrderItems { get; set; } // A product can be part of many order items

        [ValidateNever]
        public ICollection<ProductIngredient>? ProductIngredients { get; set; } // A product can have many ingredients
    }
}