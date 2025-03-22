namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class MicroVideoOptic : CyberOptics
{
    public override string Name { get { return "Микро-Видео камера"; } }

    public MicroVideoOptic()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это видеокамера, установленная B кибероптике, которая записывает видимое изображение " +
            "на внутреннюю видеокассету (20 минут). Этот рекордер также можно подключить через интерфейсные" +
            " разъёмы K внешнему источнику. Занимает 2 слота опций.";
        HumanityLossFormula = "0.5";
        Cost = 300;
        optionsReqired = 2;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
