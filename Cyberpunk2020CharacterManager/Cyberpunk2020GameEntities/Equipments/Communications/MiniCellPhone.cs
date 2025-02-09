namespace Cyberpunk2020GameEntities.Equipments.Communications;

public  class MiniCellPhone : Equipment
{
    public override string Name { get { return "Мини Сотовый Телефон"; } }

    public override int BookIndex { get; set; } = 4;

    public MiniCellPhone()
    {
        Description = " Помещается в пачку сигарет";
        Cost = 800;
    }
}
