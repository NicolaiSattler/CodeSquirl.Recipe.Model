using System;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public interface IMeal
    {
        MealType Type { get; set; }
        Guid RecipyID { get; set; }
    }
}
