namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class IndependentAirSupply : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Независимая подача воздуха"; } }

    public IndependentAirSupply() 
    {
        SurgeryCode = SurgeryCode.Major;
        Description = " Маленький искусственный орган, " +
            "наполненный губчатой пеной для фиксации кислорода. Имплан- тированный в " +
            "нижней части лёгких, он позволяет неактивному персонажу задер- живать " +
            "дыхание до 25 минут или активному персонажу до 10 минут.";
        HumanityLossFormula = "2D6";
        Cost = 300;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
