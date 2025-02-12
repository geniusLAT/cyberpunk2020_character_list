namespace Cyberpunk2020GameEntities.Equipments.CustomEquipment;

public class CustomEquipment : Equipment
{
    public void SetName(string name)
    {
        RealName = name;
    }

    public override string Name { get { return RealName; } }

    public CustomEquipment()
    {
        RealName = "Кастом";
        Description = "";
        Cost = 10;
    }
}
