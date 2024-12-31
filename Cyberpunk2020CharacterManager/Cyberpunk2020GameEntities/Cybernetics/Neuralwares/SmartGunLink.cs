
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class SmartGunLink : Neuralware
{
    public override string Name { get { return "Коннектор для умного оружия"; } }

    public SmartGunLink()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Умное оружие - это модифицированные версии обычного огнестрельного оружия, " +
            "связанного с внутренним микрокомпьютером, который, в свою очередь, подключен к оператору-человеку." +
            "Умное оружие использует небольшой звуковой или лазерный проектор, чтобы зафиксировать цель, " +
            "сканируя её тысячи раз в секунду. Когда оружие наведено на желаемую цель, компьютерная связь " +
            "принимает твой умственный сигнал \"Огонь\"(или поступающие данные из прицельного видоискателя твоей кибероптики) " +
            "и активирует оружие.Умное оружие гораздо точнее, чем большинство других пушек, их использование автоматически" +
            " даёт +2 K любой атаке огнестрельным оружием, которую ты совершаешь.Адаптации обычного оружия в конфигурацию" +
            " умного оружия вдвое повышает обычную стоимость оружия.";
        HumanityLossFormula = "2";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if(PotentialParents(character).Count == 0)
        {
            result.Append("Требуется основной нейронный процессор\n");
        }

        result.Append(UniquenessPotentialProblem(character));

        return result.ToString();
    }

    List<BodyPart>? cashedPotentialParents = null;

    public override List<BodyPart>? PotentialParents(Character character)
    {
        if(cashedPotentialParents != null)
        {
            return cashedPotentialParents;
        }

        cashedPotentialParents = [];
        foreach (var bodyPart in character.BodyParts)
        {
            if(bodyPart is BasicProcessor)
            {
                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }
}
