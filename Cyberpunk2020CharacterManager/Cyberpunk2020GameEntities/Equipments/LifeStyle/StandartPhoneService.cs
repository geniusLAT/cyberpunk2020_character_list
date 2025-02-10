namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class StandartPhoneService : Equipment
{
    public override string Name { get { return "Обычное обслуживание связи (на месяц)"; } }

    public override int BookIndex { get; set; } = 1;

    public StandartPhoneService()
    {
        Description = "";
        Cost = 30;
    }
}
