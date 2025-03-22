namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class LowLite : CyberOptics
{
    public override string Name { get { return "Слабое освещение"; } }

    public LowLite()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "позволяет пользователю четко видеть при слабом освещении, " +
            "вплоть до очень слабого лунного света или отдалённых уличных фонарей.";
        HumanityLossFormula = "0.5";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
