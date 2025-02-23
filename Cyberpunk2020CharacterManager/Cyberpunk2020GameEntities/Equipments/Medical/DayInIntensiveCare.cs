namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class DayInIntensiveCare : Equipment
{
    public override string Name { get { return "День в интенсивной терапии"; } }

    public override int BookIndex { get; set; } = 12;

    public DayInIntensiveCare()
    {
        Description = "";
        Cost = 1000;
    }
}
