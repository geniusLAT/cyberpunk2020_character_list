namespace Cyberpunk2020GameEntities.Equipments.Surveillance;

public class Binoculars : Equipment
{
    public override string Name { get { return "Биноколь"; } }

    public override int BookIndex { get; set; } = 1;

    public Binoculars()
    {
        Description = " Тут не о чем говорить.";
        Cost = 20;
    }
}
