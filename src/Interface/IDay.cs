using System;
using System.Collections.Generic;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public interface IDayPlan
    {
        int Weeknumber { get; set; }
        DayName Name { get; set; }
        IList<Meal> MealCollection { get; }
    }
}
