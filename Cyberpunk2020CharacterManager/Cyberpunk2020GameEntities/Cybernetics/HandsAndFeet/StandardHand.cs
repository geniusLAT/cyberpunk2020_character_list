using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.HandsAndFeet;

public class StandardHand : HandImplant
{
    public override string Name { get { return namePrefix +"Обычная кисть"; } }

    public string namePrefix { get; set; }

    public StandardHand()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " это похоже на нормальную кисть четыре пальца и большой палец." +
            " На кисть можно нанести покрытие или броню, как на часть остальной руки.";
        HumanityLossFormula = "0";
        Cost = 150;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0;
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Эту кисть некуда прикрепить\n");
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
            if (bodyPart is Cyberarm)
            {
                var alreadyHasHandImplant = false;
                foreach (var child in character.GetChildBodyParts(bodyPart.Guid))
                {
                    if(child is HandImplant)
                    {
                        alreadyHasHandImplant=true;
                        continue;
                    }
                    
                }

                if (alreadyHasHandImplant) { continue; }
                
                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }

    public override void ChipIn(Character character, Random random)
    {
        var arm = character.GetBodyPart(BodyPlace);
        if (arm == null) { throw new Exception("lost parent"); }

        var slot = character.GetBodyPart(arm.BodyPlace);
        if (slot == null) { throw new Exception("lost grandparent"); }

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
