namespace Cyberpunk2020GameEntities.Cybernetics.BuiltInCyberlimbs;

public class MiniVid : BuiltInCyberlimb
{
    public override string Name { get { return "Мини Видео"; } }

    public MiniVid()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "всплывающая видеокамера с микрофоном, которая" +
            " может хранить до 4 часов записанного изображения.";
        HumanityLossFormula = "2";
        Cost = 400;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
    }
}
