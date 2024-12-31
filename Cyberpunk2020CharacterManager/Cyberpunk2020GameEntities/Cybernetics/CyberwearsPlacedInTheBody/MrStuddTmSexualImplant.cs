namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class MrStuddTmSexualImplant : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Мр. Перчик Сексуальный имплант"; } }

    public MrStuddTmSexualImplant() 
    {
        SurgeryCode = SurgeryCode.Major;
        Description = "Всегда хорош, каждую ночь, и она никогда не узнает. " +
            "Используй своё воображение и добавьте + 1 K своим проверкам Соблазнения. " +
            "Доступно также версии \"Полуночная леди\" для женской стороны.";
        HumanityLossFormula = "2D6";
        Cost = 300;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
