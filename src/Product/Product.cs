using System;

namespace CodeSquirl.RecipeApp.Model
{
    public class Product
    {
        public int ID { get; set; }
        public Guid UniqueID { get; set; }
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public bool Perishable { get; set; }
        public bool Deleted { get; set; }

        public Product()
        {
            
        }
    }
}
