using System;
using System.Collections.Generic;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public interface IInstruction
    {
        Guid ReferenceID { get; }
        string Description { get; set; }
        IList<Necessity> Necessities { get; } 
    }
}
