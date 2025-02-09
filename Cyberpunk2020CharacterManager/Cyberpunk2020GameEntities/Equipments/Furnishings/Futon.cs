namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class Futon : Equipment
{
    public override string Name { get { return "Футон"; } }

    public override int BookIndex { get; set; } = 3;

    public Futon()
    {
        Description = "переносная раскладушка и подушка, японского происхождения.";
        Cost = 90;
    }
}
