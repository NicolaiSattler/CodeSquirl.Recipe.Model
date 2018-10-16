using System;
using System.Collections.Generic;

namespace CodeSquirl.Recipy.Model
{
    public class Instruction
    {
        public int ID { get; set; }        
        public Guid UniqueID { get; set; }
        public Guid ReferenceID { get; }
        public string Description { get; set; }
        public IList<Necessity> Necessities { get; } 
        public bool Deleted { get; set; }

        public Instruction(Guid referenceId)
        {
            ReferenceID = referenceId;
            Necessities = new List<Necessity>();
        }
    }
}
