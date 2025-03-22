namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class ColorShift : CyberOptics
{
    public override string Name { get { return "Переключение цвета"; } }

    public ColorShift()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта кибероптика может менять цвет или рисунок радужной оболочки по требованию. " +
            "Полное изменение цвета занимает около минуты. Зеркальные, прозрачные, " +
            "блестящие или светящиеся версии также доступны.";
        HumanityLossFormula = "0.5";
        Cost = 300;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
