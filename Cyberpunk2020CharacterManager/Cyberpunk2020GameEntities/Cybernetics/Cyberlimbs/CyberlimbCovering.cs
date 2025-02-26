using Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public abstract class CyberlimbCovering : Implant
{
    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Нет непокрытой конечности, куда можно это нанести\n");
        }

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
            if ((bodyPart is Cyberarm) || (bodyPart is Cyberleg))
            {

                var alreadyHasCovering = false;
                foreach (var child in character.GetChildBodyParts(bodyPart.Guid))
                {
                    if (child is CyberlimbCovering)
                    {
                        alreadyHasCovering = true;
                        continue;
                    }

                }

                if (alreadyHasCovering)
                {
                    continue;
                }
                var implant = (Implant)bodyPart;
                if (implant.OptionsAlloweded < 1)
                {
                    //throw new Exception($"{implant.Name} {implant.OptionsAlloweded}");

                    continue;
                }

                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }

    public override void ChipIn(Character character, Random random)
    {
        var slot = character.GetBodyPart(BodyPlace);
        ((Implant)slot).OptionsAlloweded--;

        base.ChipIn(character, random);
    }
}
