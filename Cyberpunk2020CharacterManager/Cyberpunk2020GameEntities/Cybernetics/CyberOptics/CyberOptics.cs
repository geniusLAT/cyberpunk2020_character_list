﻿using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

public abstract class CyberOptics : Implant
{
    protected int optionsReqired = 1;

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Требуется оптический модуль\n");
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
            if (bodyPart is OpticalModule)
            {
                var implant = (Implant)bodyPart;
                if (implant.OptionsAlloweded < optionsReqired)
                {
                    continue;
                }
                var alreadyContainsIt = false;
                foreach (var child in character.GetChildBodyParts(bodyPart.Guid))
                {
                    if (child.GetType() == this.GetType())
                    {
                        alreadyContainsIt = true;
                    }
                }
                if (alreadyContainsIt)
                {
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
        ((Implant)slot).OptionsAlloweded -= optionsReqired;

        
        base.ChipIn(character, random);
    }
}
