namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class DigitalRecorder : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Цифровой рекордер"; } }

    public DigitalRecorder() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Это устройство может записывать входные данные от внутренних микрофонов, от цифрового канала записи, " +
            "цифровой камеры или всех трёх. Устройство хранится B собственном подкожном кармане и может записывать до 2 часов информации на каждый чип.";
        HumanityLossFormula = "2";
        Cost = 200;
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
