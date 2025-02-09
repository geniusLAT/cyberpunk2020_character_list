namespace Cyberpunk2020GameEntities.Equipments.Vehicles;

public class ElectricMotorcycle : Vehicle
{
    public override string Name { get { return "Мотоцикл с электродвигателем"; } }

    public override int BookIndex { get; set; } = 2;

    public ElectricMotorcycle()
    {
        Description = "это обновленные версии стандартных мотоциклов. " +
            "Большинство из них являются \"лежачими\" конструкциями C пластиковыми обтекателями, " +
            "расположенными над водителем. Около половины имеют электрическое питание, максимальная " +
            "скорость 105 км в час и около 8 часов в пути после быстрой зарядки. ";
        Cost = 1500;
    }
}
