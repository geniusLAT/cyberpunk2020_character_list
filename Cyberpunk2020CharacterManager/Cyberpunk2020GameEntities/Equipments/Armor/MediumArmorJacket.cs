namespace Cyberpunk2020GameEntities.Equipments.Armor;

public class MediumArmorJacket : Armor
{
    public override string Name { get { return "Средняя броне-куртка"; } }

    public override int BookIndex { get; set; } = 6;

    public MediumArmorJacket() 
    {
        Description = "";

        MaxStoppingPower = CurrentStoppingPower = 18;
        EncumberanceValue = 1;
        Cost = 200;

        protectedBodyParts = [
            ProtectedBodyPart.Torso,
            ProtectedBodyPart.Arms
            ];
    }
}
