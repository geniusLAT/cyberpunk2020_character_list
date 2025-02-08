namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class Rope : Equipment
{
    public override string Name { get { return "Верёвка (1 фут)"; } }

    public Rope()
    {
        Description = " плетёная синтетика различной толщины и веса. Может выдержать до 450 кг.";
        Cost = 2;
    }
}
