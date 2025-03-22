using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class SpikeHeelFoot : FootImplant
{
    public override string Name { get { return namePrefix + "Пяточный шип"; } }

    public SpikeHeelFoot()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "15 сантиметровый шип выдвигается из пятки этой ступни," +
            " позволяя пользователю наносить смертельные удары ногой (урон 2D6 (ББ)). " +
            "Может использоваться для становления на якорь или для лазания.";
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
            result.Append("Эту ступню некуда прикрепить\n");
        }

        return result.ToString();
    }
}
