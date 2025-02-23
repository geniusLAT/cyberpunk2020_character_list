namespace Cyberpunk2020GameEntities.Equipments.Security;

public class TracerButton : Equipment
{
    public override string Name { get { return "Жучок слежения"; } }

    public override int BookIndex { get; set; } = 15;

    public TracerButton()
    {
        Description = " могут быть любого размера - от спичечной коробки до булавки. " +
            "Используют радиоактивность, или непрерывную / импульсную радиопередачу, " +
            "чтобы точно обозначить, того, к кому, или к чему, они подключены." +
            " Некоторые могут быть включены / выключены дистанционно. Обычно покупаются в наборах по 6.";
        Cost = 50;
    }
}
