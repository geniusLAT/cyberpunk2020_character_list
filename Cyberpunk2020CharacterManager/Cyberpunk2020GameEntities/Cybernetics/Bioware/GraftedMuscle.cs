namespace Cyberpunk2020GameEntities.Cybernetics.Bioware;

public class GraftedMuscle : Implant
{
    public int bonus { get; set; } = 1;

    public override string Name 
    { 
        get {
            var bonusNote = bonus == 2 ? " x2" :string.Empty;
            return $"Наращенные мышцы{bonusNote}"; 
        }
    }

    public GraftedMuscle()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "это выращенные в резервуарах мышцы, прививаемые к тебе, с полным заживле- нием. " +
            "С помощью этой модификации ты можешь увеличить своё Телосложение до 2 пунктов, заплатив 1000eb " +
            "за пункт. Его можно сочетать с Оплеткой мускул и костей.";
        HumanityLossFormula = "2D6";
        Cost = 1000;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        var count = 0;
        foreach (var bodyPart in character.BodyParts)
        {
            if ((bodyPart is GraftedMuscle))
            {
                count += ((GraftedMuscle)bodyPart).bonus;
            }
        }

        if(count > 1)
        {
            return "Наращенные мыщцы не могут дать более 2 очков телосложения. Этот персонаж максимально нарастил" +
                " мыщцы";
        }

        return string.Empty;
    }

    public override void ChipIn(Character character, Random random)
    {
        GraftedMuscle firstMuscles = null;
        foreach (var bodyPart in character.BodyParts)
        {
            if ((bodyPart is GraftedMuscle))
            {
                firstMuscles = (GraftedMuscle)bodyPart;
            }
        }

        if (firstMuscles == null)
        {
            character.BodyParts.Add(this);
            character.CurrentMoney -= Cost;
            GenerateHumanLoss(random);
            character.RecalculateTotalHumanityLoss();
        }
        else
        {
            character.CurrentMoney -= Cost;
            firstMuscles.Cost *= 2;
            firstMuscles.bonus *= 2;
        }
        character.body_stat++;
    }
}
