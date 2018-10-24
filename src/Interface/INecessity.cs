using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface INecessity : IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        bool Electrical { get; set; }
    }
}
