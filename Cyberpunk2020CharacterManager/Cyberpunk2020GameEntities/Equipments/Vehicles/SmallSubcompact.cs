namespace Cyberpunk2020GameEntities.Equipments.Vehicles;

public class SmallSubcompact : Vehicle
{
    public override string Name { get { return "Малый субкомпакт"; } }

    public override int BookIndex { get; set; } = 5;

    public SmallSubcompact()
    {
        Description = "обычно с метаноловым или СНООН2 приводом, эти машины " +
            "имеют максимальную скорость около 145 км в час, бак объёмом 38 литров и четыре, " +
            "относительно комфортных, посадочных мест.";
        Cost = 6000;
    }
}
