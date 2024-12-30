namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class NasalFilters : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Назальные фильтры"; } }

    NasalFilters() 
    {
        SurgeryCode = SurgeryCode.Minor;
        HumanityLoss = 2;
        Cost = 60;
    }
}
