using System;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public interface IUnit
    {
        int Value { get; set; }
        UnitType Type { get; set; }
    }
}
