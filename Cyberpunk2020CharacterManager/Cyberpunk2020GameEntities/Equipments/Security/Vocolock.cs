namespace Cyberpunk2020GameEntities.Equipments.Security;

public class Vocolock : SecurityLevel
{
    public override string Name { get { return "Блокировка  голосом"; } }

    public override int BookIndex { get; set; } = 2;

    public Vocolock()
    {
        Description = " Блокировка голосом является электронной." +
            " Блокировка голосом использует технологию распознания голоса.";
        Cost = 200;
    }
}
