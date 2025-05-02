namespace Cyberpunk2020GameEntities.Cybernetics.Fashionware;

public class LightTattoo : Implant
{
    public override string Name { get { return "Светящиеся Татуировки"; } }

    public LightTattoo()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это свето- излучающие химические элементы, вставленные" +
            " под первые пару слоёв кожи. Они накапливают свет и излучают его цветными узорами.";
        HumanityLossFormula = "0.5";
        Cost = 1;
        MaxCost = 20;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }

    public override string BarriersForChipIn(Character character)
    {
        return string.Empty;
    }
}
