
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public abstract class ReflexBooster : Neuralware
{

    private string OtherReflexBoosterFoundPotentialProblem(Character character)
    {
        foreach (var item in character.BodyParts)
        {
            if(item is ReflexBooster)
            {
                return $"{item.Name} уже установлен в качестве ускорителя рефлексов\n";
            }
        }
        return string.Empty ;
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if(PotantialParents(character).Count == 0)
        {
            result.Append("Требуется основной нейронный процессор\n");
        }

        result.Append(OtherReflexBoosterFoundPotentialProblem(character));

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
