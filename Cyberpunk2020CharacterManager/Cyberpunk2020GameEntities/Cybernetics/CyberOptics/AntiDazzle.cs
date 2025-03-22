namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class AntiDazzle : CyberOptics
{
    public override string Name { get { return "Защита от ослепления"; } }

    public AntiDazzle()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "автоматическое понижение уровня компенсирует сильный солнечный свет, вспышки и т.д., " +
            "нейтрализуя эффекты от стробоскопов, световых бомб и ярких фар. Солнцезащитные очки больше" +
            " никогда не понадобятся.";
        HumanityLossFormula = "0.5";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
