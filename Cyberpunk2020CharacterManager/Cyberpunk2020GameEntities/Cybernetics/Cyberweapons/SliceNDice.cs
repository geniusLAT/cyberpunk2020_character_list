using Cyberpunk2020GameEntities.Cybernetics.Natural;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberweapons;

public class SliceNDice : Nails
{
    public override string Name { get { return "Slice N' Dice (Мономолекулярная нить)"; } }

    public SliceNDice()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "катушка с моно-волоконной проволокой, закреплённая на конце одного пальца," +
            " с фальш-ногтем утяжелителем, чтобы придать ей вес при раскручивании. Мономолекуляр- ная " +
            "проволока прорежет практически любой органический материал и большинство пластиков." +
            " Может использоваться как гаррота, резак или хлыст. Считается формой кибероружия с Чёрного Рынка," +
            " и поэтому она недоступна для имплантации в обычной клинике или в торговом центре.";
        HumanityLossFormula = "3D6";
        Cost = 700;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Нет подходящей руки\n");
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
            if ((bodyPart is NaturalArm))
            {

                var alreadyHasIt = false;
                foreach (var child in character.GetChildBodyParts(bodyPart.Guid))
                {
                    if (child is Nails)
                    {
                        alreadyHasIt = true;
                        continue;
                    }

                }

                if (alreadyHasIt)
                {
                    continue;
                }

                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }
}
