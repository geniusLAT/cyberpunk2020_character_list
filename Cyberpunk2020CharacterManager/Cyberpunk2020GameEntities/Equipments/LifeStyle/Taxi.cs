namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class Taxi : Equipment
{
    public override string Name { get { return "Такси за милю"; } }

    public override int BookIndex { get; set; } = 9;

    public Taxi()
    {
        Description = "";
        Cost = 3;
    }
}
