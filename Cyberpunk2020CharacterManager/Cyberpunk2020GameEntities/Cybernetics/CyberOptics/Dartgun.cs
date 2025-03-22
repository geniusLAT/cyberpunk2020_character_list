namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class Dartgun : CyberOptics
{
    public override string Name { get { return "Дротикомёт"; } }

    public Dartgun()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "один выстрел дротиком. Радиус действия 1 метр, +2 к точности." +
            " Ядовитый дротик автоматически пробьет SP равному или менее 6, SP 8 с вероятностью 50%, " +
            "но только для Мягкой Брони. Занимает 3 опциональных пространства.";
        HumanityLossFormula = "2";
        Cost = 200;
        optionsReqired = 3;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
    }
}
