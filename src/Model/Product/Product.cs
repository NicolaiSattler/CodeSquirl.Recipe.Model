using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Product : IProduct
    {
        public Guid UniqueID { get; set; }
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public bool Perishable { get; set; }

        public Product()
        {
            
        }
    }
}
