namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class Air : Equipment
{
    public override string Name { get { return "Воздух за минуту"; } }

    public override int BookIndex { get; set; } = 7;

    public Air()
    {
        Description = "просто то, что написано. В США, Великобритании и некоторых частях Восточной Европы" +
            " ежедневное загрязнение становится настолько сильным, что тебе понадобится справочник \"воздушных баров\", " +
            "торговцев или уличных автоматов, чтобы купить возможность благоприятно подышать.";
        Cost = 5;
    }
}
