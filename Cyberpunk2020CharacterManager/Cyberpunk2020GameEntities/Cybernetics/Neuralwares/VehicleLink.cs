using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class VehicleLink : Neuralware
{
    public override string Name { get { return "Коннектор для транспорта"; } }

    public VehicleLink()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "позволяет пользователю управлять транспортным средством методом " +
            "прямого умственного контроля. Кибер - транспорт это автомобили, AV-4, самолёты, " +
            "вертолёты и мотоциклы, у которых обычные системы управления заменены на компьютер." +
            " Персонаж подключается непосредственно к компьютеру C помощью Интерфейсных разъёмов и " +
            "кабелей, посылая команды через свою нервную систему. Затем сервоприводы управляют колёсами, " +
            "нажимают на акселераторы и управляют торможением.Кибер - транспорт нечеловечески отзывчив -как вождение продолжения самого себя. " +
            "В результате, автомобиль с кибер-помощью автоматически даёт тебе + 2 к любому навыку вождения, пилотирования или езды " +
            "на мотоцикле, который ты используешь для характерного кибертранспорта и дополнительно добавляет 40 % от базовой стоимости автомобиля.";
        HumanityLossFormula = "3";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss =3;
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if(PotentialParents(character).Count == 0)
        {
            result.Append("Требуется основной нейронный процессор\n");
        }

        result.Append(UniquenessPotentialProblem(character));

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
