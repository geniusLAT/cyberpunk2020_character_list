using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class ToolHand : HandImplant
{
    public override string Name { get { return namePrefix + "Кисть-инструментарий"; } }

    public ToolHand()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "четыре пальца этой руки скрывают маленькие микро- инструменты:" +
            "\n 1.Отвертка со сменными насадками" +
            "\n 2.Разводной ключ" +
            "\n 3.Паяльник с аккумулятором" +
            "\n 4. Ключ трещотка " +
            "\nНижняя грань ладони закалена, чтобы образовывать молоток.";
        HumanityLossFormula = "2";
        Cost = 200;
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
