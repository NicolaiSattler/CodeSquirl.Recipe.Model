using System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Ingredient
    {
        public int ID { get; set; }
        public Guid UniqueID { get; set; }
        public Product Product { get; set; }
        public Unit Amount { get; set; }
        public bool Deleted { get; set; }

        public Ingredient()
        {
            
        }
    }
}
