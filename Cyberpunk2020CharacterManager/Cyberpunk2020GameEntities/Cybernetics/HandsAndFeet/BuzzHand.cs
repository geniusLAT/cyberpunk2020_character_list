using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class BuzzHand : HandImplant
{
    public override string Name { get { return namePrefix + "Кисть-триммер"; } }

    public BuzzHand()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Эта рука может сложиться назад оголяя небольшую мономолекулярную проволоку " +
            "вращающуюся вокруг титановой втулки. Высокоскоростная \"газонокосилка\" разрезает " +
            "большинство материалов как масло. Урон 2D6 + 2, защита мягкой брони уменьшается на 2 единицы за удар.";
        HumanityLossFormula = "2D6";
        Cost = 600;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7); ;
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Эту кисть некуда прикрепить\n");
        }

        return result.ToString();
    }
}
