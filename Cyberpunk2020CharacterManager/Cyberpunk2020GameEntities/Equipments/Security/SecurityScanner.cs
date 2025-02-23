namespace Cyberpunk2020GameEntities.Equipments.Security;

public class SecurityScanner : Equipment
{
    public override string Name { get { return "Сканер безопасности"; } }

    public override int BookIndex { get; set; } = 7;

    public SecurityScanner()
    {
        Description = " это устройство обнаруживает электромагнитные поля," +
            " создаваемые различными системами сигнализации (вероятность обнаружения 75%). " +
            "Может понадобиться совершить бросок ТЕХ или ИНТ для определения стиля тревоги " +
            "обнаруженного при срабатывании.";
        Cost = 1500;
    }
}
