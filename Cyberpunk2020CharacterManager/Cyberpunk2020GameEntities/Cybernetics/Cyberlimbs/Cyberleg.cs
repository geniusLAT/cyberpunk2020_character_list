using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class Cyberleg : Implant, IArm
{
    public override string Name { get { return namePrefix +"Кибернога"; } }

    public string namePrefix { get; set; }

    public int MaxStoppingPower { get; set; }

    public int CurrentStoppingPower { get; set; }

    public int MaxSdp { get; set; }

    public int FunctionSdpThreshold { get; set; }

    public int CurrentSdp { get; set; }

    public Cyberleg()
    {
        SurgeryCode = SurgeryCode.Critical;
        Description = "";
        HumanityLossFormula = "2D6";
        Cost = 2000;
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
               
                if (character.GetChildBodyParts(bodyPart.Guid).First() is Cyberleg)
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
        var otherLegs = character.GetChildBodyParts(BodyPlace);
        if (otherLegs.Any()) {
            character.BodyParts.Remove(otherLegs.First());
        }

        var slot = character.GetBodyPart(BodyPlace);
        if (slot == null) { throw new Exception("lost parent"); }

        if (((LegSlot)slot).IsLeft)
        {
            namePrefix = "Левая ";
        }
        else
        {
            namePrefix = "Правая ";
        }

        OptionsAlloweded = 3;

        base.ChipIn(character, random);
    }
}
