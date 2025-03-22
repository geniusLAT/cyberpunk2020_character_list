using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class VoiceStressAnalyzer : CyberAudio
{
    public override string Name { get { return "Анализатор голосовых паттернов"; } }

    public VoiceStressAnalyzer()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " эта система действует как детектор лжи, обнаруживая " +
            "незначительные изменения вокальных паттернов и тонов, и сравнивая их " +
            "с предварительно записанным набором параметров. Сначала ты должен использовать " +
            "анализатор на субъекте, когда он / она находится в не напряженном состоянии или говорит правду. " +
            "Все последующие тесты дадут тебе +2 к проверке навыка Понимание людей или Допрос" +
            " для этого конкретного субъекта.";
        HumanityLossFormula = "1";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
