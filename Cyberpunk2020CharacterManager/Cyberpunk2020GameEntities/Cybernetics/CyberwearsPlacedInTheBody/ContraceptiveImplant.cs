namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class ContraceptiveImplant : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Противозачаточный имплант"; } }

    public ContraceptiveImplant() 
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " Имплантиро- ванный под левую подмышку, он предотв- ращает беременность на срок до пяти лет. Доступно для обоих полов.";
        HumanityLossFormula = "3D6";
        Cost = 300;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
