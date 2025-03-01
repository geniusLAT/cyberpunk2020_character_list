using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class ReinforcedJoints : Implant
{
    public override string Name { get { return "Усиленные суставы"; } }

    public ReinforcedJoints()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " они сделаны из титановой стали вместо нержавеющей, и добавляют +5 SDP к киберконечности.";
        HumanityLossFormula = "1";
        Cost = 300;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Нет подходящей конечности\n");
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

                var alreadyHasShielding = false;
                foreach (var child in character.GetChildBodyParts(bodyPart.Guid))
                {
                    if (child is MicrowaveEmpShielding)
                    {
                        alreadyHasShielding = true;
                        continue;
                    }

                }

                if (alreadyHasShielding)
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

        if(slot is Cyberarm)
        {
            var arm = (Cyberarm)slot;
            arm.MaxSdp += 5;
            arm.CurrentSdp += 5;
            arm.OptionsAlloweded--;
        }

        if (slot is Cyberleg)
        {
            var leg = (Cyberleg)slot;
            leg.MaxSdp += 5;
            leg.CurrentSdp += 5;
            leg.OptionsAlloweded--;
        }

        base.ChipIn(character, random);
    }
}
