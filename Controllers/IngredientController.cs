﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
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
        }


        // Ingredient?create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IngredientId, Name")] Ingredient ingredient)
        {
            if (ModelState.IsValid)
            {
                await ingredients.AddAsync(ingredient);
                return RedirectToAction(nameof(Index));
            }
            return View(ingredient);
        }

        // Ingredient?Delete
        [HttpGet]

        public async Task<IActionResult> Delete(int id)
        {
            return View(await ingredients.GetByIdAsync(id, new QueryOptions<Ingredient> { Includes = "ProductIngredients.Product"}));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(Ingredient ingredient)
        {
          
            await ingredients.DeleteAsync(ingredient.IngredientId);
            return RedirectToAction("Index");
           
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View(await ingredients.GetByIdAsync(id, new QueryOptions<Ingredient> { Includes = "ProductIngredients.Product"}));
        }
    }
}