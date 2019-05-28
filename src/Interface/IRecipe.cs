using System;
using System.Collections.Generic;

namespace CodeSquirrel.RecipeApp.Model
{
    public class IRecipe
    {
        Guid UserID { get; set; }
        string Name { get; set; }
        RecipeType Type { get; set; }
        DietType Diet { get; set; }
        IList<IIngredient> Ingredients { get; }
        IList<IInstruction> Instructions { get; }
        TimeSpan Duration { get; }
        bool AllowRemnants { get; set; }
    }
}
