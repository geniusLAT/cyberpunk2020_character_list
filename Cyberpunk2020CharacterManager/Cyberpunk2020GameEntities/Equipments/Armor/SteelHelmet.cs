namespace Cyberpunk2020GameEntities.Equipments.Armor;

public class SteelHelmet : Armor
{
    public override string Name { get { return "Стальной шлем"; } }

    public override int BookIndex { get; set; } = 3;

    public SteelHelmet() 
    {
        Description = "Усиленная защита головы, стандартная для большинства военных." +
            " Некоторые сделаны из стали, другие из кевлара и ударопрочного пластика. " +
            "Большинство (90%) имеют лицевые щитки с 1/2 уровня SP от остальной часть шлема.";

        MaxStoppingPower = CurrentStoppingPower = 14;
        EncumberanceValue = 0;
        Cost = 20;

        protectedBodyParts = [
            ProtectedBodyPart.Head
            ];
    }
}
