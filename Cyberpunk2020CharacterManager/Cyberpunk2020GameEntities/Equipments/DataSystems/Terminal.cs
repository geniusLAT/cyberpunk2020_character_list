namespace Cyberpunk2020GameEntities.Equipments.DataSystems;

public class Terminal : Equipment
{
    public override string Name { get { return "Терминал"; } }

    public override int BookIndex { get; set; } = 8;

    public Terminal()
    {
        Description = "компьютерная рабочая станция с клавиатурой, видео экраном и разъёмами ввода / вывода. " +
            "Терминал может использоваться для Нетрана " +
            " (что делает Раннера невосприимчивым к большинству Чёрного ЛЬДа), " +
            "но очень, очень медленного (-5 навыку Интерфейс). Терминальные операторы " +
            "обычно известны как \"сетевые черепахи\".";
        Cost = 400;
    }
}
