using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Product : Entity, IProduct
    {
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public bool Perishable { get; set; }

        public Product()
        {
            
        }
    }
}
