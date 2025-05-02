namespace Cyberpunk2020GameEntities.Cybernetics.Fashionware;

public class ChemSkins : Implant
{
    public override string Name { get { return "Хим-Кожа"; } }

    public ChemSkins()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это специальные красители и химикаты, которые втираются в кожу или пропитывают её. " +
            "Некоторые меняют цвет кожи на новый по твоему желанию. Другие чувствительны к температуре" +
            " и меняют цвета в ярких узорах при нагревании или охлаждении. Очень дороги Хим-кожи" +
            " чувствительны к гормональным изменениям; Ты можешь купить Хим-кожу, из-за которой " +
            "на твоей коже появятся жёлтые и чёрные тигровые полоски, когда ты злишься или взволнован.";
        HumanityLossFormula = "1D6/2";
        Cost = 200;
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
