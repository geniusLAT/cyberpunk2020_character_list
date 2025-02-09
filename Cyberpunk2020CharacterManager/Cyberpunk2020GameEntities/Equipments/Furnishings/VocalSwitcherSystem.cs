namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class VocalSwitcherSystem : Equipment
{
    public override string Name { get { return "Голосовая Система Выключателей"; } }

    public override int BookIndex { get; set; } = 9;

    public VocalSwitcherSystem()
    {
        Description = "голосовое управление освещением и техникой.";
        Cost = 100;
    }
}
