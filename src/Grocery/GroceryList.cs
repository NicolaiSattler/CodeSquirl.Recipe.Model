using System;
using System.Collections.Generic;

namespace CodeSquirl.RecipeApp.Model
{
    public class GroceryList
    {
        public int ID { get; set; }
        public Guid UniqueID { get; set; }
        public int WeekNummer { get; set; }
        public IList<Day> DayCollection { get; }
        public Guid UserID { get; set; }
        public bool Deleted { get; set; }

        public GroceryList()
        {
            DayCollection = new List<Day>();
        }
    }
}
