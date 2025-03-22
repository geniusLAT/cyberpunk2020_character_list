using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class PainEditor : Neuralware
{
    public override string Name { get { return "Редактор боли"; } }

    public PainEditor()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Этот сопроцессор переоп- ределяет болевые рецепторы мозга, делая человека невосприимчивым к пыткам, " +
            "лишениям или физическим трудностям. Это не значит, что он не пострадает, просто он не заметит этого, пока не рухнет" +
            " (ты совершаешь проверки на Выносливость, но на два уровня сложности ниже, чем обычно)";
        HumanityLossFormula = "2D6";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
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
