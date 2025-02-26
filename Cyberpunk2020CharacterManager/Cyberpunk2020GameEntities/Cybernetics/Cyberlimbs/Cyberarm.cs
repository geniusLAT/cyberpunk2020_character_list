using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class Cyberarm : Implant, IArm
{
    public override string Name { get { return namePrefix +"Киберрука"; } }

    public string namePrefix { get; set; }

    public Cyberarm()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "";
        HumanityLossFormula = "2D6";
        Cost = 3000;
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
               
                if (character.GetChildBodyParts(bodyPart.Guid).First() is Cyberarm)
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
        var otherHands = character.GetChildBodyParts(BodyPlace);
        if (otherHands.Any()) {
            character.BodyParts.Remove(otherHands.First());
        }

        var slot = character.GetBodyPart(BodyPlace);
        if (slot == null) { throw new Exception("lost parent"); }

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
