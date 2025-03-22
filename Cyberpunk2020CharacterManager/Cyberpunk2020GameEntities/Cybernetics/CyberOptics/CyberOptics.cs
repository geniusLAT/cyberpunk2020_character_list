using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public abstract class CyberOptics : Implant
{
    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Требуется оптический модуль\n");
        }

        result.Append(UniquenessPotentialProblem(character));

        return result.ToString();
    }

    List<BodyPart>? cashedPotentialParents = null;

    public override List<BodyPart>? PotentialParents(Character character)
    {
        if (cashedPotentialParents != null)
        {
            return cashedPotentialParents;
        }

        cashedPotentialParents = [];
        foreach (var bodyPart in character.BodyParts)
        {
            if (bodyPart is OpticalModule)
            {
                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }
}
