namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class RadarSensor : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Радарный датчик"; } }

    public RadarSensor() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Hадарный блок дальностью 100 м, имплантированный в плечо, с излучателем в черепе. " +
            "Имплантат образует видимую выпуклость на лбу.\n\nРадиолокатор дальностью 100 м." +
            " В наличие должна быть кибер-оптика. Эффективность 70%.";
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
