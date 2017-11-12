using System;
using System.Collections.Generic;

namespace CodeSquirl.Recipy.Model
{
    public class Day
    {
        public int CI { get; set; }

        public Guid ID { get; set; }

        public int Weeknumber { get; set; }

        public DayName Name { get; set; } = DayName.Undefined;

        public IList<Meal> Meal { get; set; } = new List<Meal>();

        public bool Deleted { get; set; }
    }
}
