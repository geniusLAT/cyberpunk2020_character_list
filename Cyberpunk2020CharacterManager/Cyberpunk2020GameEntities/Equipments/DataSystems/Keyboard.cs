namespace Cyberpunk2020GameEntities.Equipments.DataSystems;

public class Keyboard : Equipment
{
    public override string Name { get { return "Клавиатура"; } }

    public override int BookIndex { get; set; } = 7;

    public Keyboard()
    {
        Description = "может быть добавлена к твоему кибермодему или другой электронной аппаратуре.";
        Cost = 100;
    }
}
