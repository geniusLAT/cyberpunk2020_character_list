namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class MicroOptics : CyberOptics
{
    public override string Name { get { return "Микро-Оптика"; } }

    public MicroOptics()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " это эквивалент лабораторного микроскопа, позволяющий пользователю видеть " +
            "микроскопические изображения, такие как отпечатки пальцев, царапины на замках и т.д.";
        HumanityLossFormula = "0.5";
        Cost = 150;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
