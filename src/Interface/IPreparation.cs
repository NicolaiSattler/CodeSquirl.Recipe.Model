using System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IPreparation
    {
        Guid RecipyId { get; }
        TimeSpan Duration { get; }
        TimeSpan WaitTime { get; }
    }
}
