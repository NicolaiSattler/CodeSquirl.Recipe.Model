namespace CodeSquirl.RecipeApp.Model
{
    public enum UnitType
    {
        Undefined = 0,
        Pinch = 1,
        Teaspoon = 2,
        Spoons = 3,
        Grams = 4,
        KiloGrams = 5,
        MiliLiter = 6,
        CentiLiter = 7,
        DeciLiter = 8,
        Liter = 9,
        Piece = 10
    }

    public enum ProductType
    {
        Undefined = 0,
        Grains = 1,
        Fruit = 2,
        Dairy = 3,
        Vegetable = 4,
        Meat = 5,
        Fish = 6,
        Snack = 7,
        NonAlcaholicDrink = 8,
        AlcaholicDrink = 9,
        Potatoes = 10,
        Vegetables = 11,
        HerbsAndSpices = 12,
        NutsAndSeeds = 13,
        Oil = 14,
        Soya = 15,
        Sugar = 16,
        Sauces = 17,
        Pet = 50,
        HouseHold = 75,
        Extra = 100
    }

    public enum RecipyType
    {
        Undefined = 0,
        Breakfast = 1,
        Brunch = 2,
        Lunch = 3,
        Appetizer = 4,
        Starter = 5,
        Dish = 6,
        MainDish = 7,
        Dessert = 8,
        Snack = 9
    }

    public enum DietType
    {
        Undefined = 0,
        All = 1,
        Vegitarian = 2,
        Vegan = 3,
        GlutenFree = 4,
        LactoseFree = 5
    }

    public enum MealType
    {
        Undefined = 0,
        Breakfast = 1,
        Lunch = 2,
        Dinner = 3
    }

    public enum DayName
    {
        Undefined = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saterday = 6,
        Sunday = 7
    }
}
