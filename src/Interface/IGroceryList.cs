using System;
using System.Collections.Generic;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IGroceryList : IEntity
    {
        int WeekNummer { get; set; }
        IList<Day> DayCollection { get; }
        Guid UserID { get; set; }
    }
}
