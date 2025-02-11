namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class HealthPlan : Equipment
{
    public override string Name { get { return "Медицинское страхование за месяц"; } }

    public override int BookIndex { get; set; } = 5;

    public HealthPlan()
    {
        Description = "";
        Cost = 1000;
    }
}
