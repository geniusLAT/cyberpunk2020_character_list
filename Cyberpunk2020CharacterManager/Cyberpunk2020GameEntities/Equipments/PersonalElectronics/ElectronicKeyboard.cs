namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class ElectronicKeyboard : Equipment
{
    public override string Name { get { return "Электронные клавишные"; } }

    public ElectronicKeyboard()
    {
        Description = "не сильно изменились по сравнению с нынешними, за исключением размеров и мощности.";
        Cost = 200;
        MaxCost = 900;
    }
}
