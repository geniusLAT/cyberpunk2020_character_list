namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class Air : Equipment
{
    public override string Name { get { return "Воздух за минуту"; } }

    public override int BookIndex { get; set; } = 7;

    public Air()
    {
        Description = "";
        Cost = 5;
    }
}
