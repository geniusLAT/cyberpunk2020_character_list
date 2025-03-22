using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class WebFoot : FootImplant
{
    public override string Name { get { return namePrefix + "Перепончатая ступня"; } }

    public WebFoot()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " Вытягивает тонкие перепонки с обейх сторон стопы, a также перепонки" +
            " между пальцами. Удваивает нормальную скорость плавания и добавляет +3 к навыку Плавание.";
        HumanityLossFormula = "2";
        Cost = 500;
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
