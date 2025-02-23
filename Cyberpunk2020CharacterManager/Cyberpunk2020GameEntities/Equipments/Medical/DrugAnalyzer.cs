namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class DrugAnalyzer : Equipment
{
    public override string Name { get { return "Анализатор Наркотиков"; } }

    public override int BookIndex { get; set; } = 8;

    public DrugAnalyzer()
    {
        Description = "может быть гаджетом, размером от книги до портфеля, " +
            "работает аналогично Химическому Анализатору. Он будет сверять " +
            "пробу препарата с известным составом или определять молекулярный " +
            "состав и возможные эффекты неизвестного вещества, которое похоже на " +
            "препарат, уже запрограммированный в его библиотеке.";
        Cost = 75;
    }
}
