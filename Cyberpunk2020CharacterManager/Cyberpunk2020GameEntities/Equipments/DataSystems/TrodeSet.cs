namespace Cyberpunk2020GameEntities.Equipments.DataSystems;

public class TrodeSet : Equipment
{
    public override string Name { get { return "Комплект электродов"; } }

    public override int BookIndex { get; set; } = 6;

    public TrodeSet()
    {
        Description = " низкоэффективная гарнитура для подключения к Сети. -2 к навыку Интерфейс.";
        Cost = 20;
    }
}
