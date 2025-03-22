using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class SpikeHand : HandImplant
{
    public override string Name { get { return namePrefix + "Кисть c шипом"; } }

    public SpikeHand()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта кисть содержит закаленный титановый шип, который выдвигается из запястья и" +
            " проходит через нижнюю часть ладони. Может быть отравлен и полезен для лазания. Урон 1D6 + 3 (ББ).";
        HumanityLossFormula = "2D6";
        Cost = 500;
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
            result.Append("Эту кисть некуда прикрепить\n");
        }

        return result.ToString();
    }
}
