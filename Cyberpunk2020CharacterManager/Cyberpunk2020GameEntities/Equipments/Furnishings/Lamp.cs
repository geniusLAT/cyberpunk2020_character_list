namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class Lamp : Equipment
{
    public override string Name { get { return "Лампа"; } }

    public override int BookIndex { get; set; } = 7;

    public Lamp()
    {
        Description = "даёт свет. Поставляется в бесконечном разнообразии форм и цветов.";
        Cost = 20;
    }
}
