using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class HammerHand : HandImplant
{
    public override string Name { get { return namePrefix + "Кисть-молот"; } }

    public HammerHand()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта рука сделана из закалённого титана и имеет мощный взрывной заряд," +
            " который действует как пневмомолот. Ты бьешь, заряд детонирует, толкая кулак вперед с " +
            "невероятной скоростью и силой (1D10 урона). Порт B верхней части" +
            " выбрасывает отработанный снаряд и открывается, чтобы получить новый (стоимость заряда 3 eb).\r\n";
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
