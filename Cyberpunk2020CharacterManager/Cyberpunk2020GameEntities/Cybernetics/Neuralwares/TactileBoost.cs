using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class TactileBoost : Neuralware
{
    public override string Name { get { return "Тактильное усиление"; } }

    public TactileBoost()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Увеличивает результат любого броска Осведомлённости связанного с " +
            "прикосновениями на +2. Усиление может быть включено или выключено по желанию," +
            " для этого требуется один ход.";
        HumanityLossFormula = "22";
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
