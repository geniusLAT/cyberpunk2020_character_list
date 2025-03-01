using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class QuickChangeMount : Implant
{
    public override string Name { get { return "Быстросменные крепления"; } }

    public QuickChangeMount()
    {
        SurgeryCode = SurgeryCode.Critical;
        Description = "они позволяют пользователю менять кибер конечности без использования инструментов. " +
            "Конечность установлена на байонете и может быть удалена нажатием на " +
            "фиксатор большим пальцем поворотом влево. Быстросменные крепления также можно " +
            "использовать на запястьях или голеностопных суставах, что позволяет использовать " +
            "различные кисти или стопы. Чтобы рассчитать Потерю человечности, усредни Потерю человечности " +
            "от всех опций, которые ты используешь с креплениями, затем удвой ЧИСЛО.";
        HumanityLossFormula = "2";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
    }

    public override string BarriersForChipIn(Character character)
    {
        var result = new StringBuilder();
        if (PotentialParents(character).Count == 0)
        {
            result.Append("Нет подходящей конечности\n");
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
            if ((bodyPart is Cyberarm) || (bodyPart is Cyberleg))
            {

                var alreadyHasShielding = false;
                foreach (var child in character.GetChildBodyParts(bodyPart.Guid))
                {
                    if (child is QuickChangeMount)
                    {
                        alreadyHasShielding = true;
                        continue;
                    }

                }

                if (alreadyHasShielding)
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

    public override void ChipIn(Character character, Random random)
    {
        var slot = (Cyberlimb)character.GetBodyPart(BodyPlace);
        slot.OptionsAlloweded--;     
        slot.NamePrefix += "быстросменная ";
        slot.IsQuickMounted = true;
        IsQuickMounted = true ;

        var limbSlot = (LimbSlot)character.GetBodyPart(slot.BodyPlace);
        slot.NamePostFix = generateNamePostfix(character, limbSlot);

        base.ChipIn(character, random);

        limbSlot.HasQuickMount = true;
        limbSlot.CalculateHumanityLoss(character);

        character.RecalculateTotalHumanityLoss();
    }

    private string generateNamePostfix(Character character, LimbSlot limbSlot)
    {
        var otherLimbs = character.GetChildBodyParts(limbSlot.Guid);
        var count = otherLimbs.Count;
        if(count == 0 || count == 1)
        {
            return string.Empty;
        }
        return " " + count.ToString();
    }
}
