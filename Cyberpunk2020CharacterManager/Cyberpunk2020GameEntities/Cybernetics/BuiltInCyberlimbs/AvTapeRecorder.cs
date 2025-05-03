using Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

namespace Cyberpunk2020GameEntities.Cybernetics.BuiltInCyberlimbs;

public class AvTapeRecorder : BuiltInCyberlimb
{
    public override string Name { get { return "Аудио / видео магнитофон"; } }

    public AvTapeRecorder()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Это устройство использует микрокассеты для хранения входных данных со своего внутреннего микрофона," +
            " видеокамеры или цифрового канала записи.";
        HumanityLossFormula = "1";
        Cost = 250;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
