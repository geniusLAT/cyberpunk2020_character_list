namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class RealSkin : CyberlimbCovering
{
    public override string Name { get { return "Покрытие RealSkin"; } }

    public RealSkin()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " Самый дорогой вариант - Realskinn, гибкий пластик, очень похожий на кожу," +
            " с фолли- кулами, волосками, небольшими шрамами " +
            "и дефектами, он имеет 75 % шанс сойти за \"мясную\" конечность " +
            "для всех, кроме самых внимательных наблюдателей.";
        HumanityLossFormula = "-";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = - random.Next(1, 7) / 2;
    }
}
