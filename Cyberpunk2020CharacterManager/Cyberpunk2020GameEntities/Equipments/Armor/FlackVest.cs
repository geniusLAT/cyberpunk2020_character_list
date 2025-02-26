namespace Cyberpunk2020GameEntities.Equipments.Armor;

public class FlackVest : Armor
{
    public override string Name { get { return "Бронированный жилет"; } }

    public override int BookIndex { get; set; } = 7;

    public FlackVest() 
    {
        Description = "Стандартная защита для солдат на передовой, " +
            "бронежилет предназначен для остановки огня из оружия малого калибра," +
            " осколков гранат, но только для замедления выстрелов штурмовой винтовки.";

        MaxStoppingPower = CurrentStoppingPower = 20;
        EncumberanceValue = 1;
        Cost = 200;

        protectedBodyParts = [
            ProtectedBodyPart.Torso
            ];
    }
}
