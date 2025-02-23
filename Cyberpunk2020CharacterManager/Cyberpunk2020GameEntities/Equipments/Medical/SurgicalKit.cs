namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class SurgicalKit : Equipment
{
    public override string Name { get { return "Хирургический комплект"; } }

    public override int BookIndex { get; set; } = 5;

    public SurgicalKit()
    {
        Description = "полный набор инструментов хирурга" +
            " (скальпель, ретрактор, зонд, зажим, пинцет и т.д.)," +
            " а также химикаты или оборудование для поддержания" +
            " стерильности операционного пространства.";
        Cost = 400;
    }
}
