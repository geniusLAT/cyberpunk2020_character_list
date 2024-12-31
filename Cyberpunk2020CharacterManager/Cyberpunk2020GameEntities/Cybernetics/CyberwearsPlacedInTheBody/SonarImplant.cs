namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class SonarImplant : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Имплантированный сонар"; } }

    public SonarImplant() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Установленный в череп блок сонара с дальностью 50 м.\n\n" +
            "Сонара дальность 50 м. Только для воды. Эффективность 70%.";
        HumanityLossFormula = "2";
        Cost = 300;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
