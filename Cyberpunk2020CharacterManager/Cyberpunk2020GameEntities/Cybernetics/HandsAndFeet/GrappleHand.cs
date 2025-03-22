using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class GrappleHand : HandImplant
{
    public override string Name { get { return namePrefix + "Кисть-грейфер"; } }

    public GrappleHand()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "пальцы этой руки выгибаются назад, создавая пятипалый метательный грейфер. " +
            "Небольшая катушка на запястье содержит 30 метров тонкой, очень прочной проволоки," +
            " способной выдержать 90 кг веса.";
        HumanityLossFormula = "3";
        Cost = 350;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 3;
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
