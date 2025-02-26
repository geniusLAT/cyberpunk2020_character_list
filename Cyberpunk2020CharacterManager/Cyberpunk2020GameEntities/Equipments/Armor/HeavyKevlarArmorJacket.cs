namespace Cyberpunk2020GameEntities.Equipments.Armor;

public class HeavyKevlarArmorJacket : Armor
{
    public override string Name { get { return "Тяжёлая броне-куртка"; } }

    public override int BookIndex { get; set; } = 9;

    public HeavyKevlarArmorJacket() 
    {
        Description = "";

        MaxStoppingPower = CurrentStoppingPower = 20;
        EncumberanceValue = 2;
        Cost = 250;

        protectedBodyParts = [
            ProtectedBodyPart.Torso
            ];
    }
}
