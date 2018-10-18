using System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Necessity
    {
        public int ID { get; set; }
        public Guid UniqueID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Electrical { get; set; }

        public Necessity()
        {
            
        }
    }
}
