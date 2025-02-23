namespace Cyberpunk2020GameEntities.Equipments.Security;

public class Keylock : SecurityLevel
{
    public override string Name { get { return "Блокировка ключом"; } }

    public override int BookIndex { get; set; } = 0;

    public Keylock()
    {
        Description = " Блокировка ключом является механической блокировкой " +
            "и должна подвергаться атаке таким же образом.";
        Cost = 20;
    }
}
