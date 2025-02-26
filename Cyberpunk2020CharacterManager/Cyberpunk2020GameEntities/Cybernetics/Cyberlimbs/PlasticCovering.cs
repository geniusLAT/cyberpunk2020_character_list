namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class PlasticCovering : CyberlimbCovering
{
    public override string Name { get { return "Пластиковое покрытие"; } }

    public PlasticCovering()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " когда любая кибер-конечность находится в оголённом или непокры- том состоянии, её " +
            "можно покрыть различными способами. Самый дешёвый метод это пластиковое покрытие," +
            " доступное во множестве расцветок, аэрографией или прозрачное, встроенной подсветкой и голографией.";
        HumanityLossFormula = "-";
        Cost = 200; //TODO Max Cost
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = - random.Next(1, 7) / 2;
    }
}
