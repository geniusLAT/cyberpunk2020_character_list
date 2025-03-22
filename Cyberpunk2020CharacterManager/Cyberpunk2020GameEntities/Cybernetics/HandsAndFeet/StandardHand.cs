using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class StandardHand : HandImplant
{
    public override string Name { get { return namePrefix +"Обычная кисть"; } }

    public StandardHand()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " это похоже на нормальную кисть четыре пальца и большой палец." +
            " На кисть можно нанести покрытие или броню, как на часть остальной руки.";
        HumanityLossFormula = "0";
        Cost = 150;
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
            result.Append("Эту кисть некуда прикрепить\n");
        }

        return result.ToString();
    }
}
