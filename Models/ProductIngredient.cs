namespace Mr_and_Mrs_DineIn.Models
{
    public class ProductIngredient
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } // Navigation property to Product
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; } // Navigation property to Ingredient
    }
}