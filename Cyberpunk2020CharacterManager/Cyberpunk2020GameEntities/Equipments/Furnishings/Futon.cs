namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class Futon : Equipment
{
    public override string Name { get { return "Футон"; } }

    public Futon()
    {
        Description = "переносная раскладушка и подушка, японского происхождения.";
        Cost = 90;
    }
}
