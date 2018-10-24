using System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IPreparation : IInstruction
    {
        Guid RecipyId { get; }
        TimeSpan Duration { get; }
        TimeSpan WaitTime { get; }
        
        DateTime Start(DateTime time);
    }
}
