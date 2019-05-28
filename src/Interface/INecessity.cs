using System;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public interface INecessity
    {
        string Name { get; set; }
        string Description { get; set; }
        bool Electrical { get; set; }
    }
}
