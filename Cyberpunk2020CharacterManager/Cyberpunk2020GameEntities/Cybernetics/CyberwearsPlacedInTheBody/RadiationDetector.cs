namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class RadiationDetector : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Детектор радиации"; } }

    public RadiationDetector() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Дальность действия 10 м, эффективность обнаружения 80%." +
            " Может быть имплантирован в любую область тела, при этом на " +
            "сосцевидной кости установлена звуковая сигнализация.";
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
