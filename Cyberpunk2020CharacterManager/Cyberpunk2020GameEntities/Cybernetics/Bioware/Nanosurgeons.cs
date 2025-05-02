namespace Cyberpunk2020GameEntities.Cybernetics.Bioware;

public class Nanosurgeons : Implant
{
    public override string Name { get { return $"Нанохирурги"; } }

    public Nanosurgeons()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это микроскопические машины, приспособленные к хирургическому восстановлению. " +
            "Некоторые герметизируют повреждённые кровеносные сосуды, а другие восстанавливают повреждённые ткани," +
            " хрящи и кости с помощью полимерных микрошвов. Это улучшение удваивает обычный тем лечения (x2 пунктов).";
        HumanityLossFormula = "1D6/2";
        Cost = 6000;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) / 2;
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
