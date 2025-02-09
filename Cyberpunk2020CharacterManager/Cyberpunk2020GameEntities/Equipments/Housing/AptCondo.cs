namespace Cyberpunk2020GameEntities.Equipments.Housing;

public class AptCondo : Housing
{
    public override string Name { get { return "Квартира/апартаменты (за комнату в месяц)"; } }

    public override int BookIndex { get; set; } = 2;

    public AptCondo()
    {
        Description = string.Empty;
        Cost = 200;
    }
}
