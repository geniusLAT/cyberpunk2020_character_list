
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class CybermodemLink : Neuralware
{
    public override string Name { get { return "Коннектор для кибермодема"; } }

    public CybermodemLink()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "является базовым процессором для преобразования информации Сети в изображение. " +
            "Он заменяет более ограниченные интерфейсные программы новичков и позволяет Нетраннеру " +
            "воспринимать более широкий спектр сред, чем у его предшественников.";
        HumanityLossFormula = "1";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if(PotantialParents(character).Count == 0)
        {
            result.Append("Требуется основной нейронный процессор\n");
        }

        result.Append(UniquenessPotentialProblem(character));

        return result.ToString();
    }

    List<BodyPart>? cashedPotentialParents = null;

    public override List<BodyPart>? PotantialParents(Character character)
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
