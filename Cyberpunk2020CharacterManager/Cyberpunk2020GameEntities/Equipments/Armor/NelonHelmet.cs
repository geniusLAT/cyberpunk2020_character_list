namespace Cyberpunk2020GameEntities.Equipments.Armor;

public class NelonHelmet : Armor
{
    public override string Name { get { return "Нейлоновый шлем"; } }

    public override int BookIndex { get; set; } = 8;

    public NelonHelmet() 
    {
        Description = "Усиленная защита головы, стандартная для большинства военных." +
            " Некоторые сделаны из стали, другие из кевлара и ударопрочного пластика. " +
            "Большинство (90%) имеют лицевые щитки с 1/2 уровня SP от остальной часть шлема.";

        MaxStoppingPower = CurrentStoppingPower = 20;
        EncumberanceValue = 0;
        Cost = 100;

        protectedBodyParts = [
            ProtectedBodyPart.Head
            ];
    }
}
