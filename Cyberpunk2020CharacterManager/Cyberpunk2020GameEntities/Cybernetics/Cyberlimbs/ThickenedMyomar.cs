using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class ThickenedMyomar : Implant
{
    public override string Name { get { return "Уплотнённые миомарные волокна"; } }

    public ThickenedMyomar()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "  они дают конечностям большую силу (в 2 раза больше наносимого урона) и" +
            " долговечность (+5 SDP). Прыжки усилены на 50%.";
        HumanityLossFormula = "2";
        Cost = 250;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
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

                var alreadyHasDamageUpgrade = false;
                foreach (var child in character.GetChildBodyParts(bodyPart.Guid))
                {
                    if (child is ThickenedMyomar ||  child is HydraulicRams )
                    {
                        alreadyHasDamageUpgrade = true;
                        continue;
                    }

                }

                if (alreadyHasDamageUpgrade)
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
