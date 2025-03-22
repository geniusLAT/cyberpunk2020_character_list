namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class EnhancedHearingRange : CyberAudio
{
    public override string Name { get { return "Расширенный Слуховой Диапазон"; } }

    public EnhancedHearingRange()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта подсистема позволяет пользователю слышать тоны B дозвуковом и " +
            "сверхзвуковом диапазонах.";
        HumanityLossFormula = "2";
        Cost = 150;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
    }
}
