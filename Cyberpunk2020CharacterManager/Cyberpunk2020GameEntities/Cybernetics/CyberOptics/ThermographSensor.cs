namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class ThermographSensor : CyberOptics
{
    public override string Name { get { return "Датчик тепловизора"; } }

    public ThermographSensor()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "позволяет пользователю видеть тепловые характеристики объектов, людей. " +
            "Более холодные вещи выглядят как тёмно-синие, более горячие - красные или оранжевые," +
            " а самые горячие - желтые или белые. Используется для определения различных источников " +
            "теплового излучения через тонкие материалы или наличия кибернетики (которая всегда холоднее," +
            " чем нормальная температура тела). Можно также определить время работы определенного оборудования" +
            " путём измерения его градиента охлаждения.";
        HumanityLossFormula = "1";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
