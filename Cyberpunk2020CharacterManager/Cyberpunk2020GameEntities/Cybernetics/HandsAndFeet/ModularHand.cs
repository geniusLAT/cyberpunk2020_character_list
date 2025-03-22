using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class ModularHand : HandImplant
{
    public override string Name { get { return namePrefix + "Модульная кисть"; } }

    public ModularHand()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это устройство содержит:" +
            "\n 1.Инжектор наркотиков." +
            "\n 2. 1-метровая проволока гаррота, выходящая из кончика пальца." +
            "\n 3. 2,5 см мономолекулярный нож для резки." +
            "\n 4.Отмычка." +
            "Кроме того, есть место для хранения пальцев 5 на 5 см.";
        HumanityLossFormula = "2";
        Cost = 600;
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
