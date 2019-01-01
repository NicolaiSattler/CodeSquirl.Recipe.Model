using System;
using System.Collections.Generic;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public class GroceryList : IGroceryList
    {
        public int WeekNummer { get; set; }
        public IList<DayPlan> DayCollection { get; }
        public Guid UserID { get; set; }

        public GroceryList()
        {
            DayCollection = new List<DayPlan>();
        }
    }
}
