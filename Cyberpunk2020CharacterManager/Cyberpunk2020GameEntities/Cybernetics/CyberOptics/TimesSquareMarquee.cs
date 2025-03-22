namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class TimesSquareMarquee : CyberOptics
{
    public override string Name { get { return "Всплывающее Окно"; } }

    public TimesSquareMarquee()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Пробегающий красный буквенный экран в верхней части поля зрения," +
            " связанный либо со считывателем программного чипа, либо с радиоканалом.";
        HumanityLossFormula = "1";
        Cost = 300;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
