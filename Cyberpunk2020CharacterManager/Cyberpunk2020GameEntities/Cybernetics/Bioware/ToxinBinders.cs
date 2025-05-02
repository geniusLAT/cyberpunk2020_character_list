namespace Cyberpunk2020GameEntities.Cybernetics.Bioware;

public class ToxinBinders : Implant
{
    public override string Name { get { return $"Блокировщики Токсинов"; } }

    public ToxinBinders()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " это наноиды, предназначенные для блокирования токсинов и ядов в теле." +
            " Это улучшение добавляет +4 ко всем спас-броскам против ядов.";
        HumanityLossFormula = "1D6/2";
        Cost = 3000;
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
