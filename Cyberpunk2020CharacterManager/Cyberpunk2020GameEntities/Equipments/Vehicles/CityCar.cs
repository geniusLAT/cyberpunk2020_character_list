namespace Cyberpunk2020GameEntities.Equipments.Vehicles;

public class CityCar : Vehicle
{
    public override string Name { get { return "Городской автомобиль"; } }

    public override int BookIndex { get; set; } = 4;

    public CityCar()
    {
        Description = "одноместный (в лучшем случае двухместный), трёхколесный, распространенный B корпоративных зонах. " +
            "Максимальная скорость около 64 км в час, с 4 часами езды после быстрой зарядки." ;
        Cost = 2000;
    }
}
