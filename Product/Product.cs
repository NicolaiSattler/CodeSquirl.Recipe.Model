using System;

namespace CodeSquirl.Recipy.Model
{
    public class Product
    {
        public Product() { }

        public Guid ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public ProductType Type { get; set; } = ProductType.Undefined;

        public bool Perishable { get; set; }

        public bool Deleted { get; set; }
    }
}
