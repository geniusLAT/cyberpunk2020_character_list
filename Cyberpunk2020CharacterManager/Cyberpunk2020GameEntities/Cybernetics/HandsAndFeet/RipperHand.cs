using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class RipperHand : HandImplant
{
    public override string Name { get { return namePrefix + "Кисть-Потрошитель"; } }

    public RipperHand()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Это обычная кисть с лезвиями Потрошители, установленными в верхней части кисти и запястьях.";
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
