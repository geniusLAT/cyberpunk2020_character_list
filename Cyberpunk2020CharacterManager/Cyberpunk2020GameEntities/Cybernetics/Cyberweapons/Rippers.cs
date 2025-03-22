using Cyberpunk2020GameEntities.Cybernetics.Natural;
using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberweapons;

public class Rippers : Nails
{
    public override string Name { get { return "Потрошители"; } }

    public Rippers()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "более длинные и тяжёлые версии Царапок (урон 1D6 + 3 от одной руки)." +
            " Два верхних сустава каждого пальца заменены металлопластиковой оболочкой, в" +
            " которой размещены карбоновые когти длинной 7,6 см. Потрошители можно выдвинуть, " +
            "царапая рукой B кошачьем стиле. Большинство людей носят накладные ногти на своих " +
            "Потрошителях, что затрудняет их обнаружение (Сложная проверка (20) Осведомлённости)." +
            " Потрошители считаются формой кибероружия с чёрного рынка и поэтому не доступны в обычной клинике" +
            ". Потрошители режут во всех направлениях и считаются холодным оружием для поражения " +
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
