namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class Wearman : CyberAudio
{
    public override string Name { get { return "ВеарМэн"; } }

    public Wearman()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "вариант радиосоединения, ВeарМэн устанавливает двойные вибрационные колонки" +
            " на кости сосцевидного отростка, превращая твой череп в аудиосистему качеством концертного зала. " +
            "Крошечный чип, подключается к мочке уха, что позволяет подключать различные музыкальные чипы," +
            " которые выглядят как серьги. Или ты можешь подключить чип непосредственно в интер- фейсные " +
            "разъёмы. Каждый чип содержит около 100 песен. Быстрое переключение методом мягкого сжатия серьги," +
            " один трек за нажатие. Когда чип удалён, ВеарМэн выключается. Фаворит тусовщика.";
        HumanityLossFormula = "0.5";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
