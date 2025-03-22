namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class Teleoptics : CyberOptics
{
    public override string Name { get { return "Телескопическая Оптика"; } }

    public Teleoptics()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " это эквивалент 20- кратного телескопа, позволяющий пользователю ясно видеть " +
            "удаленный объект.";
        HumanityLossFormula = "0.5";
        Cost = 150;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
