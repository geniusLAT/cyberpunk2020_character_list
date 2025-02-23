namespace Cyberpunk2020GameEntities.Equipments.DataSystems;

public class CellularCybermodem : Equipment
{
    public override string Name { get { return "Сотовый Кибермодем"; } }

    public override int BookIndex { get; set; } = 3;

    public CellularCybermodem()
    {
        Description = "[ФУНКЦИОНАЛ В РАЗРАБОТКЕ]";
        Cost = 0;
    }
}
