namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class SuperChrome : CyberlimbCovering
{
    public override string Name { get { return "Покрытие Superchrome"; } }

    public SuperChrome()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " Пластиковое покрытие также может быть хромировано (популярный вариант) или покрыто " +
            "металлическим покрытием, окрашенным в золотой, синий, зелёный, красный или серебристый цвета.";
        HumanityLossFormula = "3";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 3;
    }
}
