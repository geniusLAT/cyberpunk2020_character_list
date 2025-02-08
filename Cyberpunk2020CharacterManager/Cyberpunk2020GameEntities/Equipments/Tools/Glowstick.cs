namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class Glowstick : Equipment
{
    public override string Name { get { return "Светящаяся палочка"; } }

    public Glowstick()
    {
        Description = " химический источник света в 15 см трубке. " +
            "Встряхни или надломи, чтобы активировать. Мягкий свет " +
            "продолжительностью до 6 часов. Поставляется в зеленом, синем, красном цветах.";
        Cost = 1;
    }
}
