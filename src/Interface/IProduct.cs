using System;
using CodeSquirl.System;

namespace CodeSquirl.RecipeApp.Model
{
    public interface IProduct
    {
        Guid UniqueID { get; set; }
        string Name { get; set; }
        ProductType Type { get; set; }
        bool Perishable { get; set; }
    }
}
