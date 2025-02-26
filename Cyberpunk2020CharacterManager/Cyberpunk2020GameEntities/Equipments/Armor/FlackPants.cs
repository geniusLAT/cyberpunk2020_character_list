namespace Cyberpunk2020GameEntities.Equipments.Armor;

public class FlackPants : Armor
{
    public override string Name { get { return "Бронированные брюки"; } }

    public override int BookIndex { get; set; } = 7;

    public FlackPants() 
    {
        Description = "";

        MaxStoppingPower = CurrentStoppingPower = 20;
        EncumberanceValue = 1;
        Cost = 200;

        protectedBodyParts = [
            ProtectedBodyPart.Legs
            ];
    }
}
