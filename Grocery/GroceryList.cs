using System;
using System.Collections.Generic;

namespace CodeSquirl.Recipy.Model
{
    public class GroceryList
    {
        public int CI { get; set; }

        public Guid ID { get; set; }

        public int WeekNummer { get; set; }

        public IList<Day> Days { get; set; } = new List<Day>();

        public Guid UserID { get; set; }

        public bool Deleted { get; set; }
    }
}
