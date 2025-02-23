namespace Cyberpunk2020GameEntities.Equipments.Security;

public class Cardlock : SecurityLevel
{
    public override string Name { get { return "Блокировка магнитной картой"; } }

    public override int BookIndex { get; set; } = 1;

    public Cardlock()
    {
        Description = " Блокировка магнитной картой является электронной." +
            " В блокировке магнитной картой используется магнитная кодировка";
        Cost = 100;
    }
}
