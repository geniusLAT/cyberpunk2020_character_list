namespace Cyberpunk2020GameEntities.Equipments.Entertainment;

public class VcrChipRental : Equipment
{
    public override string Name { get { return "Аренда кассеты/чипа"; } }

    public override int BookIndex { get; set; } = 1;

    public VcrChipRental()
    {
        Description = "";
        Cost = 4;
    }
}
