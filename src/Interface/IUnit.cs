using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IUnit : IEntity
    {
        int Value { get; set; }
        UnitType Type { get; set; }
    }
}
