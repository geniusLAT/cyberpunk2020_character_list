namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class ChemicalAnalyzer : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Химический анализатор"; } }

    public ChemicalAnalyzer() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Эта модификация носовых каналов анализирует запахи и разбивает их на химические компоненты." +
            "Результаты  могут быть выведены на ЖК-экран, биомонитор или всплывающее окно Times Square.";
        HumanityLossFormula = "2";
        Cost = 2;
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
