using System;
using System.Collections.Generic;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Instruction : IInstruction
    {
        public Guid ReferenceID { get; }
        public string Description { get; set; }
        public IList<Necessity> Necessities { get; } 

        public Instruction(Guid referenceId)
        {
            ReferenceID = referenceId;
            Necessities = new List<Necessity>();
        }
    }
}
