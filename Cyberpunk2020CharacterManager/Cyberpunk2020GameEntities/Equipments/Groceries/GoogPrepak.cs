namespace Cyberpunk2020GameEntities.Equipments.Groceries;

public class GoogPrepak : Equipment
{
    public override string Name { get { return "Хорошая упаковка (на неделю)"; } }

    public override int BookIndex { get; set; } = 2;

    public GoogPrepak()
    {
        Description = " хорошая еда в упаковке из ресторана. " +
            "Самые качественные готовые блюда, которые ты можешь найти." +
            " Хочешь поесть чего-то получше, приготовь это самостоятельно" +
            " (В самом деле, кто-нибудь знает, как это делается?).";
        Cost = 200;
    }
}
