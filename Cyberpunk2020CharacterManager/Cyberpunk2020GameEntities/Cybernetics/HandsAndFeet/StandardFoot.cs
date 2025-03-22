using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class StandardFoot : FootImplant
{
    public override string Name { get { return namePrefix +"Обычная ступня"; } }

    public StandardFoot()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " это похоже на нормальную ступню";
        HumanityLossFormula = "0";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0;
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
