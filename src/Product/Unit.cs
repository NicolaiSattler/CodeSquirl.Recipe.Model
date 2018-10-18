using System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Unit
    {
        public int ID { get; set; }
        public Guid UniqueID { get; set; } 
        public int Value { get; set; }
        public UnitType Type { get; set; }

        public Unit()
        {

        }
    }
}
