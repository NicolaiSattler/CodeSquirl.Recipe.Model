using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IIngredient : IEntity
    {
        IProduct Product { get; set; }
        Unit Amount { get; set; }
    }
}
