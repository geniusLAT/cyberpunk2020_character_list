using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class TalonFoot : FootImplant
{
    public override string Name { get { return namePrefix + "Когтистая ступня"; } }

    public TalonFoot()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта ступня может выдвинуть узкие лезвия, похожие на Царапки для нанесения 1D6 урона. " +
            "Считается холодным оружием для поражения бронированных целей (ББ).";
        HumanityLossFormula = "2D6";
        Cost = 600;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Эту ступню некуда прикрепить\n");
        }

        return result.ToString();
    }
}
