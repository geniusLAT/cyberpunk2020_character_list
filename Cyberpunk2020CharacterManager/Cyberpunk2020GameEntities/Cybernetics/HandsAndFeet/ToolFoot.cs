using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class ToolFoot : FootImplant
{
    public override string Name { get { return namePrefix + "Ступня-инструментарий"; } }

    public ToolFoot()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " пальцы этой ступни содержат:" +
            "\n 1.Отвертка со сменными насадками" +
            "\n 2.Разводной ключ" +
            "\n 3.Паяльник с аккумулятором" +
            "\n 4.Ключ трещотка" +
            "\n 5.Проволочная пила";
        HumanityLossFormula = "2";
        Cost = 300;
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
            result.Append("Эту ступню некуда прикрепить\n");
        }

        return result.ToString();
    }
}
