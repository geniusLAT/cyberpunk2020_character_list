namespace Cyberpunk2020GameEntities.Equipments.CustomEquipment;

public class CustomEquipment : Equipment
{
    private string _name;

    public void SetName(string name)
    {
        _name = name;
    }

    public override string Name { get { return _name; } }

    public CustomEquipment()
    {
        Description = "";
        Cost = 10;
    }
}
