using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class GripFoot : FootImplant
{
    public override string Name { get { return namePrefix + "Обхватывающая ступня"; } }

    public GripFoot()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " пальцы ноги могут вытягиваться сгибаться вокруг сантиметрового прута. " +
            "Подошвы покрыты липким прорезиненным материалом ДЛЯ увеличения сцепления. " +
            "Добавляет +2 к навыкам лазания.";
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
