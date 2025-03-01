using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class Cyberarm : Cyberlimb, IArm
{
    public override string Name { get { return NamePrefix + "Киберрука" +NamePostFix; } }

    public Cyberarm()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "";
        HumanityLossFormula = "2D6";
        Cost = 3000;

        OptionsAlloweded = 4;
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
            result.Append("Эту руку некуда прикрепить\n");
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
            if (bodyPart is ArmSlot)
            {
                var ChilBodyParts = character.GetChildBodyParts(bodyPart.Guid);
                if (ChilBodyParts.Any())
                {
                    var firstArmAtTheSlot = ChilBodyParts.First();
                    if (firstArmAtTheSlot is Cyberarm)
                    {
                        var IsThatArmQuicjMounted = false;
                        var firstCyberArmAtTheSlot = (Cyberarm)firstArmAtTheSlot;
                        var children = character.GetChildBodyParts(firstCyberArmAtTheSlot.Guid);
                        foreach (var child in children)
                        {
                            if (child is QuickChangeMount)
                            {
                                IsThatArmQuicjMounted = true;
                                break;
                            }
                        }

                        if (!IsThatArmQuicjMounted)
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