﻿namespace Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;

public  class AudioVox : CyberwearPlacedInTheBody
{
    public override string Name { get { return "Имплантированные жабры"; } }

    public AudioVox() 
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "Этот имплантат позволяет пользователю дышать относительно чистой водой " +
            "(должен быть сделан спас- бросок против яда, если источник воды загрязнён или" +
            " содержит токсичные хими- ческие вещества) до 4 часов.";
        HumanityLossFormula = "2D6";
        Cost = 700;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
