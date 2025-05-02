namespace Cyberpunk2020GameEntities.Cybernetics.Bioware;

public class EnhancedAntibodies : Implant
{
    public override string Name { get { return $"Усиленные антитела"; } }

    public EnhancedAntibodies()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это специально разработанные антитела, способные атаковать самые мощные вирусы. " +
            "В игре они удваивают скорость лечения (+1 пункт в день).";
        HumanityLossFormula = "1D6/2";
        Cost = 3000;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) / 2;
    }

    public override string BarriersForChipIn(Character character)
    {
        //Add conflict with other body armor
        return UniquenessPotentialProblem(character);
    }
}
