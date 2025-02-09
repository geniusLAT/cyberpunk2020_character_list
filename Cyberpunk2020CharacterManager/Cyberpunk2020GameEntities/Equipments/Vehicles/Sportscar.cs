namespace Cyberpunk2020GameEntities.Equipments.Vehicles;

public class Sportscar : Vehicle
{
    public override string Name { get { return "Спортивный автомобиль"; } }

    public override int BookIndex { get; set; } = 6;

    public Sportscar()
    {
        Description = "почти всегда работает на СНООН2 (у электрики просто не хватает скорости). " +
            "Максимальная скорость около 340 км в час, с баком на 38 литров. 2 места.";
        Cost = 20000;
    }
}
