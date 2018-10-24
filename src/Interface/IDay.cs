using System;
using System.Collections.Generic;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IDay : IEntity
    {
        int Weeknumber { get; set; }
        DayName Name { get; set; }
        IList<Meal> MealCollection { get; }
    }
}
