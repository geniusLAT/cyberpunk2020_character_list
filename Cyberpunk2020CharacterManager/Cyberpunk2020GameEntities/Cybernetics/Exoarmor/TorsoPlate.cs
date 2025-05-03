namespace Cyberpunk2020GameEntities.Cybernetics.Exoarmor;

public class TorsoPlate : Implant
{
    public override string Name { get { return $"Покрытие Торса Пластинами"; } }

    public TorsoPlate()
    {
        SurgeryCode = SurgeryCode.Major;
        Description = "эта группа пластин, покрывающая весь верх и низ торса, " +
            "заднюю и переднюю части, с растягивающимися соединениями на боках, " +
            "паху и талии для повышения свободы движения. (SP = 25) " +
            "Понижает твою Характеристику РЕФ на -3.";
        HumanityLossFormula = "3D6";
        Cost = 2000;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }

    public override void ChipIn(Character character, Random random)
    {
        character.cur_ref_stat -= 3;
        base.ChipIn(character, random); 
    }
}
