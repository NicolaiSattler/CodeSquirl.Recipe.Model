using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Necessity : INecessity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Electrical { get; set; }

        public Necessity()
        {
            
        }
    }
}
