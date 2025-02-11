namespace Cyberpunk2020GameEntities.Equipments.Entertainment;

public class WellDrink : Restaraunt
{
    public override string Name { get { return "Хорошая выпивка"; } }

    public override int BookIndex { get; set; } = 5;

    public WellDrink()
    {
        Description = "";
        Cost = 3;
    }
}
