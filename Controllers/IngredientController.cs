using Microsoft.AspNetCore.Mvc;
using Mr_and_Mrs_DineIn.Data;
using Mr_and_Mrs_DineIn.Models;

namespace Mr_and_Mrs_DineIn.Controllers
{
    public class IngredientController : Controller
    {
        private Repository<Ingredient> ingredients;

        public IngredientController(ApplicationDbContext context)
        {
            ingredients = new Repository<Ingredient>(context);
        }
        public async Task<IActionResult> Index()
        {
            return View(await ingredients.GetAllAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await ingredients.GetByIdAsync(id, new QueryOptions<Ingredient>() { Includes = "ProductIngredients.Product" }));


            // Ingredient?create
            [HttpGet]

            public IActionResult Create()
            {
                return View();
            }
        }
}
