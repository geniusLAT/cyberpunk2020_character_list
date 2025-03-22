namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public class ImageEnchancement : CyberOptics
{
    public override string Name { get { return "Улучшитель изображения"; } }

    public ImageEnchancement()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " графические возможности высокого разрешения позволяют пользователю улучшать и" +
            " восстанавливать видимое изображение. При активации увеличивает навык Осведомлённость на +2," +
            " позволяя пользователю более детально изучать визуальные детали.";
        HumanityLossFormula = "1";
        Cost = 300;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
