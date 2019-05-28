using System;
using System.Collections.Generic;

namespace CodeSquirrel.RecipeApp.Model
{
    public class Recipe : IRecipe
    {
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public RecipeType Type { get; set; }
        public DietType Diet { get; set; }
        public IList<Ingredient> Ingredients { get; }
        public IList<Instruction> Instructions { get; }
        public TimeSpan Duration { get; }
        public bool AllowRemnants { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Instructions = new List<Instruction>();
        }
    }
}
