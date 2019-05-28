using System;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public class Necessity : INecessity

    {
        public Guid UniqueID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Electrical { get; set; }

        public Necessity()
        {
            
        }
    }
}
