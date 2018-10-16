using System;

namespace CodeSquirl.Recipy.Model
{
    public class Meal
    {
        public int ID { get; set; }
        public Guid UniqueID { get; set; }
        public MealType Type { get; set; }
        public Guid RecipyID { get; set; }
        public bool Deleted { get; set; }

        public Meal()
        {
            
        }
    }
}
