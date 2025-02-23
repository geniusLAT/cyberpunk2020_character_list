namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class Medkit : Equipment
{
    public override string Name { get { return "Аптечка"; } }

    public override int BookIndex { get; set; } = 4;

    public Medkit()
    {
        Description = "стандартная сумка для врача или военного. " +
            "Она содержит антидоты, перевязочные материалы, препараты, " +
            "аппликаторы, медикаменты и инструменты для изучения (зонды, " +
            "депрессоры, диагностический фонарик, стетоскоп).";
        Cost = 50;
    }
}
