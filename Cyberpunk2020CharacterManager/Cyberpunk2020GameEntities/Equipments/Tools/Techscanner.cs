namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class Techscanner : Equipment
{
    public override string Name { get { return "Технический сканер"; } }

    public override int BookIndex { get; set; } = 0;

    public Techscanner()
    {
        Description = "Небольшой портативный микрокомпьютер с различными щупами и разъёмами ввода / вывода. " +
            "Технические сканеры запускают диагностические программы, выявляют и проверяют неисправные компоненты, " +
            "и отображают внутренние схемы на небольшом экране.";
        Cost = 600;
    }
}
