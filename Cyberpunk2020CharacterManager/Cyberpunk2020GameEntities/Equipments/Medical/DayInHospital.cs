namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class DayInHospital : Equipment
{
    public override string Name { get { return "День в госпитале"; } }

    public override int BookIndex { get; set; } = 11;

    public DayInHospital()
    {
        Description = "";
        Cost = 300;
    }
}
