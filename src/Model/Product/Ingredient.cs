using System;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public class Ingredient : IIngredient
    {
        public IProduct Product { get; set; }
        public Unit Amount { get; set; }

        public Ingredient()
        {
            
        }
    }
}
