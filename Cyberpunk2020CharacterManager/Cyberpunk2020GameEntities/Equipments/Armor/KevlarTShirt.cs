namespace Cyberpunk2020GameEntities.Equipments.Armor;

public class KevlarTShirt : Armor
{
    public override string Name { get { return "Кевларовая футболка"; } }

    public override int BookIndex { get; set; } = 2;

    public KevlarTShirt() 
    {
        Description = "Можно носить незаметно под большинством уличной одежды. " +
            "Остановит большинство попаданий до калибра .45 АСР.";

        MaxStoppingPower = CurrentStoppingPower = 10;
        EncumberanceValue = 0;
        Cost = 90;

        protectedBodyParts = [
            ProtectedBodyPart.Torso
            ];
    }
}
