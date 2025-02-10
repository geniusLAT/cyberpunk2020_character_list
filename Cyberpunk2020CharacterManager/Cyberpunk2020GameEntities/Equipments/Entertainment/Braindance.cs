namespace Cyberpunk2020GameEntities.Equipments.Entertainment;

public class Braindance : Equipment
{
    public override string Name { get { return "Брейнданс"; } }

    public override int BookIndex { get; set; } = 2;

    public Braindance()
    {
        Description = "";
        Cost = 20;
    }
}
