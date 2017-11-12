using System;
using System.Collections.Generic;

namespace CodeSquirl.Recipy.Model
{
    public class InstructionBase
    {
        public InstructionBase(Guid referenceId)
        {
            ReferenceID = referenceId;
        }

        public Guid ID { get; set; } = Guid.NewGuid();

        public Guid ReferenceID { get; set; }

        public string Instruction { get; set; } = "";

        public IList<Necessity> Necessities { get; set; } = new List<Necessity>();

        public bool Deleted { get; set; } = false;

    }
}
