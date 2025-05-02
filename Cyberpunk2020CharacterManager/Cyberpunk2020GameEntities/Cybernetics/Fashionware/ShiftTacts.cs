namespace Cyberpunk2020GameEntities.Cybernetics.Fashionware;

public class ShiftTacts : Implant
{
    public override string Name { get { return "(Изменяющиеся Линзы)"; } }

    public ShiftTacts()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это цветные контактные линзы, предназначенные для имитации определённых аспектов более дорогой кибероптики. " +
            "Зеркальные линзы во всех оттенках, линзы чувствительные к температуре или эмоциям, меняющие цвет по требованию," +
            " линзы с логотипом или рисунком. Они доступны в большинстве модных магазинов по уходу за телом. Взгляни на них.";
        HumanityLossFormula = "0.5";
        Cost = 1;
        MaxCost = 200;
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
