namespace Cyberpunk2020GameEntities.Equipments.Entertainment;

public class RestarauntMeal : Restaraunt
{
    public override string Name { get { return "Еда из ресторана"; } }

    public override int BookIndex { get; set; } = 6;

    public RestarauntMeal()
    {
        Description = "";
        Cost = 20;
    }
}
