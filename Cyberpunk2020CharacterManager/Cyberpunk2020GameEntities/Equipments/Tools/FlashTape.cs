namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class FlashTape : Equipment
{
    public override string Name { get { return "Светящаяся лента (1 фут)"; } }

    public FlashTape()
    {
        Description = "тоже самое что и светящаяся краска. Продолжительность 6 часов, поставляется различной ширины.";
        Cost = 10;
    }
}
