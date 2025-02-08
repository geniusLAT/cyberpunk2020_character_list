namespace Cyberpunk2020GameEntities.Equipments.Communications;

public  class MiniCellPhone : Equipment
{
    public override string Name { get { return "Мини Сотовый Телефон"; } }

    public MiniCellPhone()
    {
        Description = " Помещается в пачку сигарет";
        Cost = 100;
    }
}
