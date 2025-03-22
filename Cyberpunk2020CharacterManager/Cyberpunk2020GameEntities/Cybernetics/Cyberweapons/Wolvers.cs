using Cyberpunk2020GameEntities.Cybernetics.Natural;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberweapons;

public class Wolvers : Cyberweapon
{
    public override string Name { get { return "Когти Росомахи"; } }

    public Wolvers()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "самые длинные и самые смертельные из имплантируемых лезвий, " +
            "Когти Росомахи имплантируются вдоль тыльной стороны предплечья." +
            " Когда рука сжимается в кулак, тонкие треугольные лезвия выдвигаются и" +
            " фиксируются на месте, оставаясь вытянутыми на полную длину, пока рука не" +
            " расслабится. Урон 3D6 / рука. Рассматривается как холодное оружие для поражения " +
            "бронированных целей (ББ).";
        HumanityLossFormula = "3D6";
        Cost = 400;
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
                    if (child is Wolvers)
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
