namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class ElectronicKeyboard : Equipment
{
    public override string Name { get { return "Электронные клавишные"; } }

    public override int BookIndex { get; set; } = 13;

    public ElectronicKeyboard()
    {
        Description = "не сильно изменились по сравнению с нынешними, за исключением размеров и мощности.";
        Cost = 200;
        MaxCost = 900;
    }
}
