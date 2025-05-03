namespace Cyberpunk2020GameEntities.Cybernetics.BuiltInCyberlimbs;

public class Techscanner : BuiltInCyberlimb
{
    public override string Name { get { return "Технический сканер"; } }

    public Techscanner()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "устройство может быть подключено K системам диагностики " +
            "большинства транспортных средств, бытовой техники и персональной" +
            " электроники для определения возможных проблем и устранения " +
            "неисправностей. Надежность составляет 60%. При успешном броске" +
            " сложность ремонта снижается на -3 (ты знаешь, что не так, " +
            "и тебе просто нужно это исправить).";
        HumanityLossFormula = "3";
        Cost = 400;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 3;
    }
}
