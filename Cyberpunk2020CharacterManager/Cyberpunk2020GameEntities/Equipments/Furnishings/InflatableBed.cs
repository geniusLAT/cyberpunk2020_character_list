namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class InflatableBed : Equipment
{
    public override string Name { get { return "Надувной матрас"; } }

    public InflatableBed()
    {
        Description = "самонадувающийся пакет с высокой степенью сжатия. Около 15 х 5 х 10 см в сложенном состоянии.";
        Cost = 25;
    }
}
