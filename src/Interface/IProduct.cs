using System;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.Model
{
    public interface IProduct
    {
        Guid UniqueID { get; set; }
        string Name { get; set; }
        ProductType Type { get; set; }
        bool Perishable { get; set; }
    }
}
