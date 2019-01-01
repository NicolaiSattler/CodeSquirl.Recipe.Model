using Autofac;

namespace CodeSquirl.RecipeApp.Model
{
    public class ModelModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DayPlan>();
            builder.RegisterType<GroceryList>();
            builder.RegisterType<Meal>();
            builder.RegisterType<Ingredient>();
            builder.RegisterType<Necessity>();
            builder.RegisterType<Product>();
            builder.RegisterType<Unit>();
            builder.RegisterType<Preparation>();
            builder.RegisterType<Recipe>();
            builder.RegisterType<Instruction>();
        }
    }
}