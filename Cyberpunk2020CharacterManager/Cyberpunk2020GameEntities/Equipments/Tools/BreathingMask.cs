namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class BreathingMask : Equipment
{
    public override string Name { get { return "Дыхательная маска"; } }

    public BreathingMask()
    {
        Description = "распространённая среди стрит-арт художников. " +
            "Защита носа и рта, с двумя сменными фильтрами по бокам (10 штук в комплекте). " +
            "Хороша для защиты от смога.";
        Cost = 30;
    }
}
