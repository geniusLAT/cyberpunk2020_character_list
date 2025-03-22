using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public abstract class HandImplant : Implant
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
            if (bodyPart is Cyberarm)
            {
                var alreadyHasHandImplant = false;
                foreach (var child in character.GetChildBodyParts(bodyPart.Guid))
                {
                    if (child is HandImplant)
                    {
                        alreadyHasHandImplant = true;
                        continue;
                    }

                }

                if (alreadyHasHandImplant) { continue; }

                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }

    public override void ChipIn(Character character, Random random)
    {
        var arm = character.GetBodyPart(BodyPlace);
        if (arm == null) { throw new Exception("lost parent"); }

        var slot = character.GetBodyPart(arm.BodyPlace);
        if (slot == null) { throw new Exception("lost grandparent"); }

        if (((ArmSlot)slot).IsLeft)
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
