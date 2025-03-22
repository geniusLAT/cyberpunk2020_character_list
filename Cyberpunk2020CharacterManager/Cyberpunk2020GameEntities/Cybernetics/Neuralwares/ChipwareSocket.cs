using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class ChipwareSocket : Neuralware
{
    public override string Name { get { return "Комплект разъёмов для чипсета"; } }

    public ChipwareSocket()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " несколько небольших разъёмов, используемых только для вставки чипсета. C помощью Комплекта разъёмов для чипсета ты можешь использовать " +
            "интерфейсные разъёмы для управления другими объектами (например, оружием или транспортным средством), сохраняя при этом доступ к информации ЧПАМ и ЧРЕФ." +
            " Вмещает 10 чипов.";
        HumanityLossFormula = "1D6/2";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) /2;
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if(PotentialParents(character).Count == 0)
        {
            result.Append("Требуется основной нейронный процессор\n");
        }

        return result.ToString();
    }

    List<BodyPart>? cashedPotentialParents = null;

    public override List<BodyPart>? PotentialParents(Character character)
    {
        if(cashedPotentialParents != null)
        {
            return cashedPotentialParents;
        }

        cashedPotentialParents = [];
        foreach (var bodyPart in character.BodyParts)
        {
            if(bodyPart is BasicProcessor)
            {
                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }
}
