
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class MachineTechLink : Neuralware
{
    public override string Name { get { return "Коннектор для механизмов / техники"; } }

    public MachineTechLink()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Позволяет пользователю взаимодействовать и контролировать любые" +
            " автоматизированные станки или тяжёлые машины, работающую от системы " +
            "управления на основе \"MLINK\". Ты также можешь управлять небольшими " +
            "механизмами / приборами в не заводских условиях.";
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
