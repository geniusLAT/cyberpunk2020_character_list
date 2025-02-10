namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class DataTermUse : Equipment
{
    public override string Name { get { return "Использование ДатаТерма за минуту"; } }

    public override int BookIndex { get; set; } = 3;

    public DataTermUse()
    {
        Description = "";
        Cost = 1;
    }
}
