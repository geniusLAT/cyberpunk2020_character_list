using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

namespace Cyberpunk2020GameEntities.Cybernetics.CybeweaponsBuiltInCyberLimb;

public class TwoShotCapacitorLaser : CybeweaponBuiltInCyberLimb
{
    public override string Name { get { return "Двух Зарядный Конденсаторный Лазер"; } }

    public TwoShotCapacitorLaser()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Этот микролазер разработан для создания очень мощного импульса" +
            " ограниченной длительности (3D6 для каждого секундного выстрела). " +
            "Радиус действия ужасен (10 метров), а для зарядки требуется один час. " +
            "Тем не менее, это может быть особенно эффективным оружием для скрытных" +
            " убийств или бесшумных атак. Точность + 3.";
        HumanityLossFormula = "2D6";
        Cost = 900;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
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

                var alreadyHasThatBuiltIn = false;
                foreach (var child in character.GetChildBodyParts(bodyPart.Guid))
                {
                    if (child.GetType() == this.GetType())
                    {
                        alreadyHasThatBuiltIn = true;
                        continue;
                    }

                }

                if (alreadyHasThatBuiltIn)
                {
                    continue;
                }
                var implant = (Implant)bodyPart;
                if (implant.OptionsAlloweded < 1)
                {
                    //throw new Exception($"{implant.Name} {implant.OptionsAlloweded}");

                    continue;
                }

                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }
}
