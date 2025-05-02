namespace Cyberpunk2020GameEntities.Cybernetics.Fashionware;

public class Synthskins : Implant
{
    public override string Name { get { return "Синт-Кожа"; } }

    public Synthskins()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " более сложная версия технологии светящейся татуировки, искусственная кожа - это слой изменяющего цвет пластика, " +
            "связанный с внешней кожей персонажа. Она может быть настроена для отображения цветов, рисунков, " +
            "вспышек света или других специальных эффектов, используя микросхемы настройки (стоимость 100 eb) " +
            "которые вставляются в разъём на коже (обычно под линией волос).";
        HumanityLossFormula = "1D6";
        Cost = 400;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }
}
