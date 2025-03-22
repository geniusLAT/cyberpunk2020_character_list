using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public abstract class FootImplant : Implant
{
    public string namePrefix { get; set; }

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
            if (bodyPart is Cyberleg)
            {
                var alreadyHasFootImplant = false;
                foreach (var child in character.GetChildBodyParts(bodyPart.Guid))
                {
                    if (child is FootImplant)
                    {
                        alreadyHasFootImplant = true;
                        continue;
                    }

                }

                if (alreadyHasFootImplant) { continue; }

                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }

    public override void ChipIn(Character character, Random random)
    {
        var leg = character.GetBodyPart(BodyPlace);
        if (leg == null) { throw new Exception("lost parent"); }

        var slot = character.GetBodyPart(leg.BodyPlace);
        if (slot == null) { throw new Exception("lost grandparent"); }

        if (((LegSlot)slot).IsLeft)
        {
            namePrefix = "Левая ";
        }
        else
        {
            namePrefix = "Правая ";
        }

        base.ChipIn(character, random);
    }
}
