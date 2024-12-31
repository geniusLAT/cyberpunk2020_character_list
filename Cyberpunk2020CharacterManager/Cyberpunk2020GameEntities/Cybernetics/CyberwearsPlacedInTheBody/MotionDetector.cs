namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class MotionDetector : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Детектор движения"; } }

    public MotionDetector() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Обнаруживает движение (направление и силу) на площади 20 кв.м с эффективностью 70%. Может быть установлен на ладони или пятке.";
        HumanityLossFormula = "2D6";
        Cost = 200;
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
