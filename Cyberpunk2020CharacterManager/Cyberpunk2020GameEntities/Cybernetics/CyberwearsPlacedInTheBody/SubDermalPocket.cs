namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class SubDermalPocket : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Подкожный карман"; } }

    public SubDermalPocket() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "пластиковый карман 5 на 10 см, скрытый ПОД кожей, " +
            "C чувствительной к давлению кнопкой. для курьеров." +
            " Обнаружение Полезно СЛОЖНоЙ требует (20) проверки Осведомлённости.";
        HumanityLossFormula = "2D6";
        Cost = 200;
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
