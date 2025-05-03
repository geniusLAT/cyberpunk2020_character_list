namespace Cyberpunk2020GameEntities.Cybernetics.BuiltInCyberlimbs;

public class DigitalRecorder : BuiltInCyberlimb
{
    public override string Name { get { return "Цифровой рекордер"; } }

    public DigitalRecorder()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Это устройство может записывать входные " +
            "данные с внутренних микрофонов, цифровых каналов" +
            " записи, цифровых камер или всех трёх ОДНОвременно.";
        HumanityLossFormula = "1";
        Cost = 300;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
