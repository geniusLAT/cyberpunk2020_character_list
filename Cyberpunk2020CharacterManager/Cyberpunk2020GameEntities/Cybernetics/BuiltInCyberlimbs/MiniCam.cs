namespace Cyberpunk2020GameEntities.Cybernetics.BuiltInCyberlimbs;

public class MiniCam : BuiltInCyberlimb
{
    public override string Name { get { return "Мини Камера"; } }

    public MiniCam()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это небольшая цифровая фотокамера," +
            " которая всплывает из крепления в плече. " +
            "Внутренний чип хранит 20 изображений и " +
            "может быть легко заменён.";
        HumanityLossFormula = "2";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
    }
}
