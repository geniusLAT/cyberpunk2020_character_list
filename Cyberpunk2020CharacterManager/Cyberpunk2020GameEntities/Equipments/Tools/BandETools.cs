namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class BandETools : Equipment
{
    public override string Name { get { return "Инструменты от B&E"; } }

    public BandETools()
    {
        Description = "Примечание: в книге нет описания, но B&E - break and enter, кража со взломом.";
        Cost = 120;
    }
}
