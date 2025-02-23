namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class Airhypo : Equipment
{
    public override string Name { get { return "Пневматический Инъектор"; } }

    public override int BookIndex { get; set; } = 9;

    public Airhypo()
    {
        Description = "\"Bones McCoy\" использует быстрый выброс сжатого воздуха " +
            "чтобы ввести жидкий препарат под кожу. См. Раздел \"TRAUMA TEAM\" для" +
            " получения информации о препаратах и ценах.";
        Cost = 100;
    }
}
