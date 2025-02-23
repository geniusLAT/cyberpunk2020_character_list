namespace Cyberpunk2020GameEntities.Equipments.Security;

public class PlasKuffs : Equipment
{
    public override string Name { get { return "Наручники"; } }

    public override int BookIndex { get; set; } = 17;

    public PlasKuffs()
    {
        Description = "просто то, что написано. Вероятно, немного жёстче " +
            "(Почти невозможно сломать (30)) из-за новых сплавов. Часто (50%) " +
            "запираются с помощью Блокировки магнитной картой.";
        Cost = 100;
    }
}
