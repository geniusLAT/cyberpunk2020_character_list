namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class RadarDetector : CyberAudio
{
    public override string Name { get { return "Детектор радара"; } }

    public RadarDetector()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта система издаёт громкий звуковой сигнал всякий раз, когда " +
            "обнаруживает радарный луч. У неё также есть шанс 40% триангуляции источника." +
            " Когда направление луча определено, частые звуковые сигналы сменяются на чистый тон.";
        HumanityLossFormula = "0.5";
        Cost = 150;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
