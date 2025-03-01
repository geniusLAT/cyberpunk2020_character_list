using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class MicrowaveEmpShielding : Implant
{
    public override string Name { get { return "Микроволновое и Эми экранирование"; } }

    public MicrowaveEmpShielding()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " защищает вашу кибер-конечность электромагнитных импульсов и микроволновых атак. " +
            "Экранирование может быть помещено на любой тип конечности, независимо ТОГО, какое покрытие " +
            "используется, оно размещается внутри, занимая одно опциональное пространство в конечности.";
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
        ((Implant)slot).OptionsAlloweded--;

        base.ChipIn(character, random);
    }
}
