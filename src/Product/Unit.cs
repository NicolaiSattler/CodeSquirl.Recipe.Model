using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Unit : Entity, IUnit
    {
        public int Value { get; set; }
        public UnitType Type { get; set; }

        public Unit()
        {

        }
    }
}
