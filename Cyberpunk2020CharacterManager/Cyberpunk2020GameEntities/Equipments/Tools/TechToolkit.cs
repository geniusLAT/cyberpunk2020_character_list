namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class TechToolkit : Equipment
{
    public override string Name { get { return "Технический инструментарий"; } }

    public override int BookIndex { get; set; } = 2;

    public TechToolkit()
    {
        Description = "смешанный набор инструментов для ремонта механических объектов, обычно в футляре 10 х 40 х 10 см.";
        Cost = 100;
    }
}
