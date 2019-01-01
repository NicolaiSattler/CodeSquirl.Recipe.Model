using System;
using System.Collections.Generic;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IGroceryList
    {
        int WeekNummer { get; set; }
        IList<DayPlan> DayCollection { get; }
        Guid UserID { get; set; }
    }
}
