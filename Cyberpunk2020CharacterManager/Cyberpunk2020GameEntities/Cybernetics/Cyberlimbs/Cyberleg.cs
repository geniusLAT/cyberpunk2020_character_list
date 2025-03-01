using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class Cyberleg : Cyberlimb, IArm
{
    public override string Name { get { return namePrefix +"Кибернога"; } }

    public Cyberleg()
    {
        SurgeryCode = SurgeryCode.Critical;
        Description = "";
        HumanityLossFormula = "2D6";
        Cost = 2000;

        OptionsAlloweded = 3;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Эту ногу некуда прикрепить\n");
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
            if (bodyPart is LegSlot)
            {
                var ChilBodyParts = character.GetChildBodyParts(bodyPart.Guid);
                if (ChilBodyParts.Any())
                {
                    var firstLegAtTheSlot = ChilBodyParts.First();
                    if (firstLegAtTheSlot is Cyberleg)
                    {
                        var IsThatLegQuicjMounted = false;
                        var firstCyberLegAtTheSlot = (Cyberleg)firstLegAtTheSlot;
                        var children = character.GetChildBodyParts(firstCyberLegAtTheSlot.Guid);
                        foreach (var child in children)
                        {
                            if (child is QuickChangeMount)
                            {
                                IsThatLegQuicjMounted = true;
                                break;
                            }
                        }

                        if (!IsThatLegQuicjMounted)
                        {
                            continue;
                        }
                    }
                }

                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }
}
