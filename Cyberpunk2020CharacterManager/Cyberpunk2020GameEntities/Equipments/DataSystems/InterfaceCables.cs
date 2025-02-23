namespace Cyberpunk2020GameEntities.Equipments.DataSystems;

public class InterfaceCables : Equipment
{
    public override string Name { get { return "Интерфейсные кабели"; } }

    public override int BookIndex { get; set; } = 4;

    public InterfaceCables()
    {
        Description = "  типичный соединительный кабель для подключения киберуправляемой машины " +
            "к интерфейсным разъёмам человека.";
        Cost = 20;
        MaxCost = 30;
    }
}
