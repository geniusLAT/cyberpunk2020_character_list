namespace Cyberpunk2020GameEntities.Equipments.Armor;

public class DoorGunnersVest : Armor
{
    public override string Name { get { return "Бронижилет борт-стрелка"; } }

    public override int BookIndex { get; set; } = 10;

    public DoorGunnersVest() 
    {
        Description = "Усиленная защита для стационарных позиций, таких как " +
            "пулемётные гнезда, двери вертолёта и т.д.";

        MaxStoppingPower = CurrentStoppingPower = 25;
        EncumberanceValue = 3;
        Cost = 250;

        protectedBodyParts = [
            ProtectedBodyPart.Torso
            ];
    }
}
