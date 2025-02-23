namespace Cyberpunk2020GameEntities.Equipments.Security;

public class MovementSensor : Equipment
{
    public override string Name { get { return "Датчик движения"; } }

    public override int BookIndex { get; set; } = 11;

    public MovementSensor()
    {
        Description = "типичная сигнализация. Охватывает сейсмические, сонарные, и" +
            " ИК датчики или датчики видимого света. Обнаруживает движение в " +
            "определенной области с надежностью 95%. Сенсорный процессор" +
            " размером с пачку сигарет.";
        Cost = 40;
    }
}
