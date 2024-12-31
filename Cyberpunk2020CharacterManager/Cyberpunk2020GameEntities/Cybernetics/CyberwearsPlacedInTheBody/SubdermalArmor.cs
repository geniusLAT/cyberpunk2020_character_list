namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class SubdermalArmor : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Подкожная броня"; } }

    public SubdermalArmor() 
    {
        SurgeryCode = SurgeryCode.Critical;
        Description = "Броня туловища до 18 SP.\n\nЭто сетчатая / баллистическая пластиковая броня, вживленная под кожу." +
            " Для обнаружения подкожной брони необходим бросок на СЛОЖНУЮ (20) проверку осведомлённости. Подкожная броня покрывает только туловище";
        HumanityLossFormula = "2D6";
        Cost = 1200;
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
