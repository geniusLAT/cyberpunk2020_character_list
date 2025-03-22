using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class DataTermLink : Neuralware
{
    public override string Name { get { return "Коннектор для Дата Термов"; } }

    public DataTermLink()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Этот сопроцессор позволяет пользователю напрямую получать доступ к " +
            "информации из Дата Термов и сохранять её, передавая её на " +
            "всплывающее окно \"Times Square или экран ЖК - дисплея для воспроизведения(с точки зрения игры, это позволяет" +
            " персонажу получать доступ к информации, как если бы Дата Терм был доступен, даже если это не так).";
        HumanityLossFormula = "2";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
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
