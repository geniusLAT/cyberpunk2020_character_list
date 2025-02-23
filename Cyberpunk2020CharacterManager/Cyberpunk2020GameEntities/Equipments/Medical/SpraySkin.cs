namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class SpraySkin : Equipment
{
    public override string Name { get { return "Спрей для Кожи (1 баночка)"; } }

    public override int BookIndex { get; set; } = 1;

    public SpraySkin()
    {
        Description = " вязкий гель-спрей для лечения сильных ссадин." +
            " Антисептик И стерилизующие, он также воздухопроницаем" +
            " и отслаивается примерно через две недели.";
        Cost = 50;
    }
}
