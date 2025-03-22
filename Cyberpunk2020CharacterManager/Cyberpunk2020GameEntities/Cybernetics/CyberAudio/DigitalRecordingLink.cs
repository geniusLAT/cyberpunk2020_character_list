namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class DigitalRecordingLink : CyberAudio
{
    public override string Name { get { return "Коннектор цифрового рекордера"; } }

    public DigitalRecordingLink()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта опция позволяет записывать всё, что слышит пользователь, " +
            "на внутреннем микрочипе (2 часа). Записи могут быть загружены во внутренний " +
            "цифровой рекордер или через интерфейсные разъёмы на внешний цифровой рекордер.";
        HumanityLossFormula = "0.5";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
