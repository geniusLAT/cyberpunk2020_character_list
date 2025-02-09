namespace Cyberpunk2020GameEntities.Equipments.Vehicles;

public class Scooter : Vehicle
{
    public override string Name { get { return "Скутер"; } }

    public override int BookIndex { get; set; } = 0;

    public Scooter()
    {
        Description = "это обновлённая версия старых мотороллеров Riva и Vespa 1990-х годов с " +
            "электрическим приводом. Максимальная скорость около 80 км в час, скутеры могут провести " +
            "6 часов в пути после быстрой зарядки (около 5 минут на любой станции технического обслуживания).";
        Cost = 500;
    }
}
