namespace Cyberpunk2020GameEntities.Equipments.Armor;

public class HeavyLeather : Armor
{
    public override string Name { get { return "Тяжёлая кожа"; } }

    public override int BookIndex { get; set; } = 1;

    public HeavyLeather() 
    {
        Description = "Хороша для дорожной драки, остановки ножей и т.д. " +
            "Однако, хорошая пуля калибра .38 разорвёт тебя на куски.";

        MaxStoppingPower = CurrentStoppingPower = 4;
        EncumberanceValue = 0;
        Cost = 50;

        protectedBodyParts = [
            ProtectedBodyPart.Torso
            ];
    }
}
