using System;
using System.Collections.Generic;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public class DayPlan : IDayPlan
    {
        public int Weeknumber { get; set; }
        public DayName Name { get; set; }
        public IList<Meal> MealCollection { get; }

        public DayPlan()
        {
            MealCollection = new List<Meal>();
        }
    }
}
