namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class Infrared : CyberOptics
{
    public override string Name { get { return "Инфракрасная оптика"; } }

    public Infrared()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "позволяет пользователю видеть в почти полной темноте, " +
            "используя тепловое излучение для получения изображения.";
        HumanityLossFormula = "1";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
