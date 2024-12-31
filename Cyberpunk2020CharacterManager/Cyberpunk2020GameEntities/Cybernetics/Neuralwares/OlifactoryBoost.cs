
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class OlifactoryBoost : Neuralware
{
    public override string Name { get { return "Обонятельное усиление"; } }

    public OlifactoryBoost()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Увеличивает результат любого броска Осведомлённости на +2 при изучении запаха. " +
            "Кроме того, субъект добавляет +2 к своим навыкам Скрытное наблюдение (он может отслеживать по " +
            "запаху и имеет 50% шанс найти аромат, с которого можно начать отслеживание, если только цель не " +
            "приложит особых усилий, чтобы скрыть свой запах). Усиление может быть включено или выключено по желанию, " +
            "для этого требуется один ход";
        HumanityLossFormula = "2";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7);
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
