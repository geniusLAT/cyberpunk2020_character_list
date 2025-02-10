namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class MagLevChit : Equipment
{
    public override string Name { get { return "Маглев проездной за станцию"; } }

    public override int BookIndex { get; set; } = 8;

    public MagLevChit()
    {
        Description = "";
        Cost = 0.25f;
    }
}
