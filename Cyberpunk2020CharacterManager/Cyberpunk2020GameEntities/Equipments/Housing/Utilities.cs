namespace Cyberpunk2020GameEntities.Equipments.Housing;

public class Utilities : Equipment
{
    public override string Name { get { return "Коммунальные услуги (в месяц)"; } }

    public override int BookIndex { get; set; } = 4;

    public Utilities()
    {
        Description = string.Empty;
        Cost = 100;
    }
}
