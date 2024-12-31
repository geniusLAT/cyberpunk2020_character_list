namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class NasalFilters : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Назальные фильтры"; } }

    public NasalFilters() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "эти фильтры повышают эффективность защиты от яда, снотворного или других вдыхаемых токсичных веществ на +4.";
        HumanityLoss = 2;
        Cost = 60;
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
