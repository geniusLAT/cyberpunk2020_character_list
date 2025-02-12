namespace Cyberpunk2020GameEntities.Equipments.CustomEquipment;

public class CustomEquipment : Equipment
{
    public override string Name { get { return "Кастом"; } }

    public CustomEquipment()
    {
        Description = "";
        Cost = 10;
    }
}
