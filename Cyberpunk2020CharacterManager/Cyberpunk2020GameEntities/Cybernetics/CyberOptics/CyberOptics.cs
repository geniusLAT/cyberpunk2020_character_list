using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;
using System.Text;

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
                
                foreach (var child in character.GetChildBodyParts(bodyPart.Guid))
                {
                    //throw new NotImplementedException($"{child.GetType()}  {this.GetType()}");

                    if (child.GetType() == this.GetType())
                    {
                        continue;
                    }
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
