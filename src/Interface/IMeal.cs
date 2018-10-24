using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IMeal : IEntity
    {
        MealType Type { get; set; }
        Guid RecipyID { get; set; }
    }
}
