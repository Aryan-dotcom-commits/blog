namespace Domain.Enums
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public enum ActivityLevel

    {
        Sedentary = 0,
        LightlyActive = 1,
        ModeratelyActive = 2,
        VeryActive = 3,
        ExtraActive = 4

    }

    public enum WeightUnits
    {
        KG = 0,
        LBS = 1
    }

    public enum HeightUnits
    {
        CM = 0,
        INCHES = 1
    }

    public enum FoodCategory

    {
        Junk = 0,
        Healthy = 1,
    }

    public enum BodyPart

    {
        Chest = 0,
        Shoulders = 1,
        Triceps = 2,
        Biceps = 3,
        Back = 4,
        Legs = 5,
        Core = 6,
        Cardio = 7,
    }

    public enum Category
    {
        Cardio = 0,
        Strength = 1,
        Flexibility = 2
    }

    public enum Intensity
    {
        Low = 0,
        Medium = 1,
        High = 2,
        Extreme = 3
    }

    public enum FoodType
    {
        FastFood = 0,
        Dairy = 1,
        Vegetables = 2,
        Meat = 3
    }

    public enum MealType
    {
        Breakfast = 0,
        Lunch = 1,
        Dinner = 2,
        Snack = 3
    }

}