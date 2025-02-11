namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class CableTV : Equipment
{
    public override string Name { get { return "Кабельное ТВ за месяц"; } }

    public override int BookIndex { get; set; } = 10;

    public CableTV()
    {
        Description = "";
        Cost = 40;
    }
}
