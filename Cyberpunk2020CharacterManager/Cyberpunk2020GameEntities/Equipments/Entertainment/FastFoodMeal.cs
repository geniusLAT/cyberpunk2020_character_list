namespace Cyberpunk2020GameEntities.Equipments.Entertainment;

public class FastFoodMeal : Equipment
{
    public override string Name { get { return "Еда быстрого приготовления"; } }

    public override int BookIndex { get; set; } = 4;

    public FastFoodMeal()
    {
        Description = "";
        Cost = 5;
    }
}
