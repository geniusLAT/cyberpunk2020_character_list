using Cyberpunk2020GameEntities.Cybernetics.Natural;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberweapons;

public class BigKnucks : Cyberweapon
{
    public override string Name { get { return "Большие Костяшки"; } }

    public BigKnucks()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "усиленные костяшки, придающие кулаку ударную силу пары латунных кастетов (1D6 +2). " +
            "Они считаются формой кибероружия с Чёрного Рынка, и поэтому " +
            "недоступны для имплантации в обычной клинике, работающей в торговом центре.";
        HumanityLossFormula = "3D6";
        Cost = 500;
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
                    if (child is BigKnucks)
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
