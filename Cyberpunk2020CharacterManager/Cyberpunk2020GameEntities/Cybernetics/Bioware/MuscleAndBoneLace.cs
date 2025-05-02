namespace Cyberpunk2020GameEntities.Cybernetics.Bioware;

public class MuscleAndBoneLace : Implant
{
    public override string Name { get {return $"Оплетка мускул и костей"; }}

    public MuscleAndBoneLace()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "также процедура известна, как вирусная трансформация, это " +
            "улучшение задействует два типа наноидов. Первый тип пропускает синтетические " +
            "мышцы через естественные мышечные волокна, закрепляя и укрепляя их. " +
            "Второй тип оплетает кос- ти в тонкое переплетение металлических и пластиковых нитей, " +
            "делая их прочнее и тол- ще. Результатом является увеличение +2 к СТАТу ТЕЛО персонажа." +
            " Это увеличение как силы, так и способности поглощать физический урон. " +
            "Это улучшение, практически, невозможно обнаружить. Требуется около двух недель, " +
            "(Телосложение увеличивается на 1 каждую неделю) чтобы заработать на полную мощность.";
        HumanityLossFormula = "1D6/2";
        Cost = 1500;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7)/2;
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }

    public override void ChipIn(Character character, Random random)
    {
        character.body_stat+=2;
        base.ChipIn(character, random);
    }
}
