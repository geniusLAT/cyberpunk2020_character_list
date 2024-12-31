namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class NasalFilters : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Назальные фильтры"; } }

    public NasalFilters() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "эти фильтры повышают эффективность защиты от яда, снотворного или других вдыхаемых токсичных веществ на +4.";
        HumanityLossFormula = "2";
        Cost = 60;
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
