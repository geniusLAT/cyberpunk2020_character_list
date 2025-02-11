namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class TraumaTeamAccount : Equipment
{
    public override string Name { get { return "Обслуживание Trauma Team в месяц"; } }

    public override int BookIndex { get; set; } = 6;

    public TraumaTeamAccount()
    {
        Description = "";
        Cost = 500;
    }
}
