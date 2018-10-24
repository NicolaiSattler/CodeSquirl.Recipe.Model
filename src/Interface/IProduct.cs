using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IProduct : IEntity
    {
        string Name { get; set; }
        ProductType Type { get; set; }
        bool Perishable { get; set; }
    }
}
