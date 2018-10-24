using System;
using System.Collections.Generic;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Instruction : IInstruction
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

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public T DeepClone<T>(T source) where T : IEntity
        {
            throw new NotImplementedException();
        }

    }
}
