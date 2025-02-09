namespace Cyberpunk2020GameEntities.Equipments.Vehicles;

public class Motorcycle : Vehicle
{
    public override string Name { get { return "Мотоцикл c ДВС"; } }

    public override int BookIndex { get; set; } = 1;

    public Motorcycle()
    {
        Description = "это обновленные версии стандартных мотоциклов. " +
            "Большинство из них являются \"лежачими\" конструкциями C пластиковыми обтекателями, " +
            "расположенными над водителем. " +
            "Версии с СНООН2 приводом имеют максимальную скорость 225 км в час и бак объемом 15 литров.";
        Cost = 1500;
    }
}
