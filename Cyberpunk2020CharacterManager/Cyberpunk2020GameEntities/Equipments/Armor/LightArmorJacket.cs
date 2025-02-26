namespace Cyberpunk2020GameEntities.Equipments.Armor;

public class LightArmorJacket : Armor
{
    public override string Name { get { return "Лёгкая броне-куртка"; } }

    public override int BookIndex { get; set; } = 4;

    public LightArmorJacket() 
    {
        Description = "Персональная защита для понимающих моду. Эти лёгкие кевларовые куртки имеют " +
            "нейлоновые покрытия, которые делают их похожими на обычные куртки.";

        MaxStoppingPower = CurrentStoppingPower = 14;
        EncumberanceValue = 0;
        Cost = 150;

        protectedBodyParts = [
            ProtectedBodyPart.Torso,
            ProtectedBodyPart.Arms
            ];
    }
}
