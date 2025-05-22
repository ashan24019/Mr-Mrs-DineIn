namespace Mr_and_Mrs_DineIn.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public ICollection<ProductIngredient> ProductIngredients { get; set; } // A ingredient can be part of many products
    }
}