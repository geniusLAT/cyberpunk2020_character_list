using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

namespace Cyberpunk2020GameEntities.Cybernetics.BuiltInCyberlimbs;

public class HiddenHolster : BuiltInCyberlimb
{
    public override string Name { get { return "Потайная Кобура"; } }

    public HiddenHolster()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "только для ног. Скрытое место для хранения одного пистолета и " +
            "одного магазина дополнительного боезапаса. Размер ноги (зависящий от Телосложения)" +
            " ограничивает размер оружия, которое можно хранить. " +
            "\nОчень Слабый, Слабый…Лёгкий пистолет " +
            "\nСредний, Сильный … Средний пистолет " +
            "\nОчень сильный Тяжёлый пистолет " +
            "\nОчень сильный … Складной дробовик(2 патр, 1 / 2 дистанции)";
        HumanityLossFormula = "1";
        Cost = 100;
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
            if (bodyPart is Cyberleg)
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

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
