using System;
using System.Collections.Generic;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public class GroceryList : Entity, IGroceryList
    {
        public int WeekNummer { get; set; }
        public IList<Day> DayCollection { get; }
        public Guid UserID { get; set; }

        public GroceryList()
        {
            DayCollection = new List<Day>();
        }
    }
}
