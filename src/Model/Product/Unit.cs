using System;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public class Unit : IUnit
    {
        public Guid UniqueID { get; set; }
        public int Value { get; set; }
        public UnitType Type { get; set; }

        public Unit()
        {

        }
    }
}
