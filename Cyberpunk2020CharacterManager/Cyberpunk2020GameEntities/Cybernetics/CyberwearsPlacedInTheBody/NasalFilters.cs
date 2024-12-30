namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class NasalFilters : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Назальные фильтры"; } }

    NasalFilters() 
    {
        HumanityLoss = 2;
        cost = 60;
    }
}
