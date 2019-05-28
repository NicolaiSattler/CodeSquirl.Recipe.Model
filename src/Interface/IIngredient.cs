using System;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public interface IIngredient
    {
        IProduct Product { get; set; }
        Unit Amount { get; set; }
    }
}
