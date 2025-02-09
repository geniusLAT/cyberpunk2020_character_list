namespace Cyberpunk2020GameEntities.Equipments.Vehicles;

public class MediumSedan : Vehicle
{
    public override string Name { get { return "Средний седан"; } }

    public override int BookIndex { get; set; } = 5;

    public MediumSedan()
    {
        Description = "почти всегда работает на СНООН2 " +
            "(у электрики просто не хватает скорости)." +
            " Максимальная скорость около 145 км в час, бак на 57 литров и четыре места.";
        Cost = 10000;
    }
}
