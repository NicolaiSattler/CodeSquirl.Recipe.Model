using System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Preparation : Instruction, IPreparation
    {
        public Guid RecipyId { get; }
        public TimeSpan Duration { get; }
        public TimeSpan WaitTime { get; }
        
        public Preparation(Guid recipyId, Guid referenceId) : base(referenceId)
        {
            RecipyId = recipyId;
            Duration = new TimeSpan();
            WaitTime = new TimeSpan();
        }

        public DateTime Start(DateTime time)
        {
            return time.Subtract(Duration).Subtract(WaitTime);
        }
    }
}
