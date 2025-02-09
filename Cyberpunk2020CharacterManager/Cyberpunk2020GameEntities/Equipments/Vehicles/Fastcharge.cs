namespace Cyberpunk2020GameEntities.Equipments.Vehicles;

public class Fastcharge : Equipment
{
    public override string Name { get { return "Быстрая зарядка"; } }

    public override int BookIndex { get; set; } = 8;

    public Fastcharge()
    {
        Description = "быстрая (5 минутная) зарядка аккумулятора для электромобилей. " +
            "Доступно на большинстве сервисных станций по цене 20 евродолларов (ED / EB).";
        Cost = 20;
    }
}
