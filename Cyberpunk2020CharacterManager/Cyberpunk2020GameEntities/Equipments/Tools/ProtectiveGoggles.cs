namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class ProtectiveGoggles : Equipment
{
    public override string Name { get { return "Защитные очки"; } }

    public ProtectiveGoggles()
    {
        Description = "защитные очки для сварки, механической обработки металлов, химического смешивания и т.д.";
        Cost = 20;
    }
}
