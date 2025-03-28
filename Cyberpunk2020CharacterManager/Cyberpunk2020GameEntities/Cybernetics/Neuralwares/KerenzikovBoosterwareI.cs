﻿namespace Cyberpunk2020GameEntities.Cybernetics.Neuralwares;

public class KerenzikovBoosterwareI : ReflexBooster
{
    public override string Name { get { return "Керезников I уровня"; } }

    public KerenzikovBoosterwareI()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "+1 к инициативе\nЭтот ускоритель всегда активирован, персонаж всегда реагирует с более высокой скоростью, " +
            "чем обыч-но.Поскольку Керезников часто повышает отклик выше 10, он стоит больших Потерь Человечности, так " +
            "как пользователь должен научиться корректировать свои действия в мире, который, как ему кажется, движется в " +
            "замедленном темпе.Из - за этого Керезников может быть установлен на двух уровнях ускорения(+1 или + 2 к Инициативе, " +
            "Потеря Человечности = 1D6 или 2D6).";
        HumanityLossFormula = "1D6";
        Cost = 500;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7);
    }
}
