namespace Cyberpunk2020GameEntities.Equipments.Security;

public class Passcard : Equipment
{
    public override string Name { get { return "Идентификационная карта"; } }

    public override int BookIndex { get; set; } = 12;

    public Passcard()
    {
        Description = "самое популярное устройство для разблокировки Блокировки картой.";
        Cost = 10;
    }
}
