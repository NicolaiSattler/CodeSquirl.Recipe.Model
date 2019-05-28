using System;
using System.Collections.Generic;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public interface IGroceryList
    {
        int WeekNummer { get; set; }
        IList<DayPlan> DayCollection { get; }
        Guid UserID { get; set; }
    }
}
