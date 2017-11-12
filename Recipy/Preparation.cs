using System;

namespace CodeSquirl.Recipy.Model
{
    public class Preparation : InstructionBase
    {
        public Preparation(Guid recipyId, Guid referenceId) : base(referenceId)
        {
            RecipyId = recipyId;
        }

        public Guid RecipyId { get; private set; }

        public TimeSpan Duration { get; set; } = new TimeSpan();

        public TimeSpan WaitTime { get; set; } = new TimeSpan();

        public DateTime Start(DateTime time)
        {
            return time.Subtract(Duration).Subtract(WaitTime);
        }
    }
}
