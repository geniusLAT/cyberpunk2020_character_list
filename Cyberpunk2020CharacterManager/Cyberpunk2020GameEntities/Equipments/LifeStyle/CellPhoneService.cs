namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class CellPhoneService : Equipment
{
    public override string Name { get { return "Услуги сотовой связи (на месяц)"; } }

    public override int BookIndex { get; set; } = 0;

    public CellPhoneService()
    {
        Description = "";
        Cost = 100;
    }
}
