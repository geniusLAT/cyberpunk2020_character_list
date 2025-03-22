namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class DigitalCamera : CyberOptics
{
    public override string Name { get { return "Цифровая фотокамера"; } }

    public DigitalCamera()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта кибероптическая камера занимает слота опций." +
            " На встроенный цифровой чип можно записать до 20 изображений и загрузить их" +
            " через интерфейсные кабели на внешний рекордер, внутренний рекордер или внутренний экран. " +
            "По мере создания снимков предыдущие удаляются.";
        HumanityLossFormula = "0.5";
        Cost = 300;
        optionsReqired = 2;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
