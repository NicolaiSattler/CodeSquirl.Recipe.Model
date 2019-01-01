using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IUnit
    {
        int Value { get; set; }
        UnitType Type { get; set; }
    }
}
