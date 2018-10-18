using System;
using System.Collections.Generic;

namespace CodeSquirl.RecipeApp.Model
{
    public class Day
    {
        public int ID { get; set; }
        public Guid UniqueID { get; set; }
        public int Weeknumber { get; set; }
        public DayName Name { get; set; }
        public IList<Meal> MealCollection { get; }
        public bool Deleted { get; set; }

        public Day()
        {
            MealCollection = new List<Meal>();
        }
    }
}
