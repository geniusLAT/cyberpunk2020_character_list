namespace Cyberpunk2020GameEntities.Equipments.DataSystems;

public class Cybermodem : Equipment
{
    public override string Name { get { return "Кибермодем"; } }

    public override int BookIndex { get; set; } = 2;

    public Cybermodem()
    {
        Description = "[ФУНКЦИОНАЛ В РАЗРАБОТКЕ]";
        Cost = 0;

    }
}
