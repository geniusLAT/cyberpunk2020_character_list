namespace Cyberpunk2020GameEntities.Cybernetics.Axoarmor;

public class Cowl : Implant
{
    public override string Name { get { return $"Капюшон"; } }

    public Cowl()
    {
        SurgeryCode = SurgeryCode.Major;
        Description = "это нательная пластина, которая закрывает череп. " +
            "Он прикреплён мини-болтами к скальпу и напоминает старые шлемы" +
            " из эпичного фэнтези или плохой научной фантастики или . SP = 25.";
        HumanityLossFormula = "1D6";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
