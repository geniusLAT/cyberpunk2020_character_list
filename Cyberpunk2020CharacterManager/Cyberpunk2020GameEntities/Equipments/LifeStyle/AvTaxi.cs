namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class AvTaxi : Equipment
{
    public override string Name { get { return "AV-такси за милю"; } }

    public override int BookIndex { get; set; } = 9;

    public AvTaxi()
    {
        Description = "";
        Cost = 10;
    }
}
