using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Mr_and_Mrs_DineIn.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }

        [ValidateNever]
        public ICollection<ProductIngredient> ProductIngredients { get; set; } // A ingredient can be part of many products
    }
}