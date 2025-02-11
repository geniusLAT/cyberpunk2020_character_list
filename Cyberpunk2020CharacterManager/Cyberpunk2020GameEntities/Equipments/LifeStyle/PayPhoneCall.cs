namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class PayPhoneCall : Equipment
{
    public override string Name { get { return "Оплата телефонной связи"; } }

    public override int BookIndex { get; set; } = 2;

    public PayPhoneCall()
    {
        Description = "";
        Cost = 0.5f;
    }
}
