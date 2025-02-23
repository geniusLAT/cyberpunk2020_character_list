namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class Medscanner : Equipment
{
    public override string Name { get { return "Медицинский сканер"; } }

    public override int BookIndex { get; set; } = 7;

    public Medscanner()
    {
        Description = "считывает данные о температуре тела, сердечном ритме, артериальном давлении," +
            " дыхании и уровне сахара в крови. Небольшая база данных на чипе добавляет +2 к " +
            "твоему Навыку Диагностика Болезней.";
        Cost = 300;
    }
}
