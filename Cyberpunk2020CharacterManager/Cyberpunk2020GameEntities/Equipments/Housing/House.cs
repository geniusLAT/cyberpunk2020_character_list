namespace Cyberpunk2020GameEntities.Equipments.Housing;

public class House : Housing
{
    public override string Name { get { return "Дом (за комнату в месяц)"; } }

    public override int BookIndex { get; set; } = 3;

    public House()
    {
        Description = string.Empty;
        Cost = 150;
    }
}
