using System;

namespace CodeSquirl.Recipy.Model
{
    public class Ingredient
    {
        public Guid ID { get; set; }

        public Product Product { get; set; } = new Product();

        public Unit Amount { get; set; } = new Unit();

        public bool Deleted { get; set; }
    }
}
