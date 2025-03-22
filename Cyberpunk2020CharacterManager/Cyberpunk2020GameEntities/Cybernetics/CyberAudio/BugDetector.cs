namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class BugDetector : CyberAudio
{
    public override string Name { get { return "Детектор жучков"; } }

    public BugDetector()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "мини-приёмник предназначен для приёма сигналов," +
            " передаваемых всеми типами радио- жучков. Когда жучок активен, " +
            "его передачи вызывают тихий звуковой сигнал в затылке, становясь всё " +
            "громче по мере приближения к жучку. С точки зрения игры, это даёт " +
            "тебе 6 из 10 шансов (брось 1D10, с результатом не больше 6) обнаружения " +
            "любых жучков в пределах 3 метров от тебя. Обычная опция для Корпоратов, Фиксеров и Соло.";
        HumanityLossFormula = "0.5";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
