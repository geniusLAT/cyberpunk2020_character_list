namespace Cyberpunk2020GameEntities.Equipments.Armor;

public class MetalGear : Armor
{
    public override string Name { get { return "Метал Гир"; } }

    public override int BookIndex { get; set; } = 11;

    public MetalGear() 
    {
        Description = "Ламинированная пластинчатая броня." +
            " Громоздкая и сконструированная по принципу модульных сегментов, " +
            "со шлемом, покрытием рук и ног, передняя и задняя части торса разъединяются.";

        MaxStoppingPower = CurrentStoppingPower = 25;
        EncumberanceValue = 2;
        Cost = 600;

        protectedBodyParts = [
            ProtectedBodyPart.Head,
            ProtectedBodyPart.Torso,
            ProtectedBodyPart.Arms,
            ProtectedBodyPart.Legs
            ];
    }
}
