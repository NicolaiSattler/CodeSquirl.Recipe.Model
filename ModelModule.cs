using Autofac;

namespace CodeSquirl.Recipy.Model
{
    public class ModelModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Day>();
            builder.RegisterType<GroceryList>();
            builder.RegisterType<Meal>();
            builder.RegisterType<Ingredient>();
            builder.RegisterType<Necessity>();
            builder.RegisterType<Product>();
            builder.RegisterType<Unit>();
            builder.RegisterType<Preparation>();
            builder.RegisterType<Recipy>();
            builder.RegisterType<InstructionBase>();
        }
    }
}