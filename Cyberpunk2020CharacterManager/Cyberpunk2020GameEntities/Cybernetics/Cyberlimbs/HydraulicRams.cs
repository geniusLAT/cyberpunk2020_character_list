using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class HydraulicRams : Implant
{
    public override string Name { get { return "Гидравлические цилиндры"; } }

    public HydraulicRams()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " распространённые среди Советского кибероснащения, цилиндры являются более " +
            "объёмными и тяжелыми, чем миомарные волокна (конечность не может выглядеть как настоящая, " +
            "независимо от того, насколько хорошо она покрыта RealskinnM) ), но может получить больше " +
            "повреждений (30 SDP для отключения, 40 SDP для уничтожения), Сила конечностей также " +
            "увеличивается (трёхкратный урон от ударов руками и ногами).";
        HumanityLossFormula = "3";
        Cost = 200;
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
            arm.MaxSdp += 10;
            arm.CurrentSdp += 10;
            arm.OptionsAlloweded--;
        }

        if (slot is Cyberleg)
        {
            var leg = (Cyberleg)slot;
            leg.MaxSdp += 10;
            leg.CurrentSdp += 10;
            leg.OptionsAlloweded--;
        }

        base.ChipIn(character, random);
    }
}
