using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class AmplifiedHearing : CyberAudio
{
    public override string Name { get { return "Усиленный слух"; } }

    public AmplifiedHearing()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта система улучшает способность слышать и распознавать звук, " +
            "добавляя +1 к любой проверке осведомлённости через слух.";
        HumanityLossFormula = "1";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Требуется слуховой модуль\n");
        }

        result.Append(UniquenessPotentialProblem(character));

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
            if (bodyPart is HearingModule)
            {
                cashedPotentialParents.Add(bodyPart);
            }
        }
        return cashedPotentialParents;
    }
}
