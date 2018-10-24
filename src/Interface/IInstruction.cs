using System;
using System.Collections.Generic;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IInstruction : IEntity
    {
        Guid ReferenceID { get; }
        string Description { get; set; }
        IList<Necessity> Necessities { get; } 
    }
}
