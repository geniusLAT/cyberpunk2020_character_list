namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class AdrenalBooster : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Усилитель надпочечников"; } }

    public AdrenalBooster() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Bскусственная железа, которая выпускает гормоны надпочечников по команде. " +
            "Добавляет +1 к (REF) Рефлексам на 1D6 + 2 хода три раза в день.";
        HumanityLossFormula = "2D6";
        Cost = 400;
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
