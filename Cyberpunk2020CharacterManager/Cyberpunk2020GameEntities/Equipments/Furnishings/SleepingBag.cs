namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class SleepingBag : Equipment
{
    public override string Name { get { return "Спальный мешок"; } }

    public SleepingBag()
    {
        Description = "они легче и теперь могут выдерживать температуру до -100F. Сжимается до габаритов 30 х 15 х 10 см.";
        Cost = 25;
    }
}
