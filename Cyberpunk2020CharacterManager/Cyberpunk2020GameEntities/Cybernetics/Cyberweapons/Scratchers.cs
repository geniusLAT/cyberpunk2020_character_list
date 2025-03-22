using Cyberpunk2020GameEntities.Cybernetics.Natural;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberweapons;

public class Scratchers : Cyberweapon
{
    public override string Name { get { return "Царапки"; } }

    public Scratchers()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " Имплантированные металлические или карбоностеклянные ноги. " +
            "Невероятная острота материала делает их такими же смертоносными, как лезвия бритвы " +
            "(урон 1D6 / 2 от одной руки). Царапки режут кромками, требуя, чтобы пользователь" +
            " разрезал поперечными движениями, а не делал рывки вниз. Большинство людей лакируют свои " +
            "Царапки, делая их неотличимыми от обычных ногтей (эмаль не влияет на остроту)." +
            " Они не считаются смертоносным (и, следовательно, запрещенными) кибер- оружием," +
            " и их можно приобрести в любой местной клинике.";
        HumanityLossFormula = "2D6";
        Cost = 100;
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
                    if (child is Scratchers)
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
