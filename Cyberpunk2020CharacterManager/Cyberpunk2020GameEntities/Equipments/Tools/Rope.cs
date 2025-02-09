namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class Rope : Equipment
{
    public override string Name { get { return "Верёвка (1 фут)"; } }

    public override int BookIndex { get; set; } = 10;

    public Rope()
    {
        Description = " плетёная синтетика различной толщины и веса. Может выдержать до 450 кг.";
        Cost = 2;
    }
}
