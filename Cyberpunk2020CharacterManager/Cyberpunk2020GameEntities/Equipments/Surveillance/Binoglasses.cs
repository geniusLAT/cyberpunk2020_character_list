namespace Cyberpunk2020GameEntities.Equipments.Surveillance;

public class Binoglasses : Equipment
{
    public override string Name { get { return "Очки-бинокли"; } }

    public override int BookIndex { get; set; } = 0;

    public Binoglasses()
    {
        Description = "эти высокотехнологичные средства визуального наблюдения" +
            " сочетают в себе бинокль с лазерным дальномером, иногда и с ИК линзами. " +
            "Более дорогие версии будут иметь встроенную цифровую камеру.";
        Cost = 200;
    }
}
