namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class FlashPaint : Equipment
{
    public override string Name { get { return "Светящаяся краска"; } }

    public FlashPaint()
    {
        Description = "флуоресцентная краска выделяет мягкий свет, равный светящейся палочке, продолжительностью до 4 часов.";
        Cost = 10;
    }
}
