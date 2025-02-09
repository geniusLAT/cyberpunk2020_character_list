namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class BandETools : Equipment
{
    public override string Name { get { return "Инструменты от B&E"; } }

    public override int BookIndex { get; set; } = 3;

    public BandETools()
    {
        Description = "Примечание: в книге нет описания, но B&E - break and enter, кража со взломом.";
        Cost = 120;
    }
}
