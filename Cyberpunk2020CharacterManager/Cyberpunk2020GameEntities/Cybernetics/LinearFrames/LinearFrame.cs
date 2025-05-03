using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.LinearFrames;

public abstract class LinearFrame : Implant
{
    public int Strenght = 0;

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();

        foreach (var bodyPart in character.BodyParts)
        { 
            if(bodyPart is LinearFrame)
            {
                result.Append("Нельзя имплантировать более одной линейной рамы");
                break;
            }            
        }

        return result.ToString();
    }

    public override void ChipIn(Character character, Random random)
    {
        character.cur_ref_stat--;
        base.ChipIn(character, random);
    }
}
