using System;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public class Meal : IMeal
    {
        public MealType Type { get; set; }
        public Guid RecipyID { get; set; }

        public Meal()
        {
            
        }
    }
}
