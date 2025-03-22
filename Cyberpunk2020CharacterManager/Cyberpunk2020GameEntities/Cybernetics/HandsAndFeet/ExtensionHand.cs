using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class ExtensionHand : HandImplant
{
    public override string Name { get { return namePrefix + "Удлиняющаяся кисть"; } }

    public ExtensionHand()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта кисть может выдвигаться из телескопического запястья до 1 метра." +
            " Может выдерживать до 90 кг веса.";
        HumanityLossFormula = "2";
        Cost = 350;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
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
