namespace Cyberpunk2020GameEntities.Cybernetics.Bioware;

public class SkinWeave : Implant
{
    public override string Name { get { return $"Прошивка кожи"; } }

    public SkinWeave()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " в этом улучшении используются наноиды для прошивки трёх " +
            "верхних слоев кожи плотной полимерной нитью. В результате получается, " +
            "что SP голой кожи равный 12, что эквивалентно лёгкой броне. " +
            "Процесс является относительно незаметным (нужно пройти СЛОЖНУЮ (20) проверку " +
            "Осведомлённости, чтобы заметить) и занимает около двух недель (SP увеличивается " +
            "на 6 каждую неделю).";
        HumanityLossFormula = "2D6";
        Cost = 2000;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        //Add conflict with other body armor
        return UniquenessPotentialProblem(character);
    }
}
