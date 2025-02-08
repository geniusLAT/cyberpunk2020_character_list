namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class VocalSwitcherSystem : Equipment
{
    public override string Name { get { return "Голосовая Система Выключателей"; } }

    public VocalSwitcherSystem()
    {
        Description = "голосовое управление освещением и техникой.";
        Cost = 100;
    }
}
