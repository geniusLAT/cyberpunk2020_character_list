namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class AudioVideoTapeRecorder : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Аудио / видео магнитофон"; } }

    public AudioVideoTapeRecorder() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Это устройство использует микрокассеты для хранения входных данных от своего внутреннего микрофона, " +
            "видеокамеры или цифрового канала записи. Оно хранится в собственном подкожном кармане для лёгкого доступа. " +
            "Каждая кассета содержит 2 часа информации.";
        HumanityLossFormula = "2";
        Cost = 300;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
