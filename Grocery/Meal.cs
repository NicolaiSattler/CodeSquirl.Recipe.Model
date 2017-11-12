using System;

namespace CodeSquirl.Recipy.Model
{
    public class Meal
    {
        public int CI { get; set; }

        public Guid ID { get; set; }

        public MealType Type { get; set; } = MealType.Undefined;

        public Guid RecipyID { get; set; }

        public bool Deleted { get; set; }
    }
}
