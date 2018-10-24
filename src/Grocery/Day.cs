using System;
using System.Collections.Generic;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Day : Entity, IDay
    {
        public int Weeknumber { get; set; }
        public DayName Name { get; set; }
        public IList<Meal> MealCollection { get; }

        public Day()
        {
            MealCollection = new List<Meal>();
        }
    }
}
