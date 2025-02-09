namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class ElectronicsToolkit : Equipment
{
    public override string Name { get { return "Инструментарий для электроники"; } }

    public override int BookIndex { get; set; } = 4;

    public ElectronicsToolkit()
    {
        Description = "смотри выше.";
        Cost = 100;
    }
}
