namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class DataTermUse : Equipment
{
    public override string Name { get { return "Использование ДатаТерма за минуту"; } }

    public override int BookIndex { get; set; } = 3;

    public DataTermUse()
    {
        Description = " это стационарный компьютерный терминал с доступом к новостям, погоде, карте города," +
            " расписанию событий и другим полезным материалам. Информационный терминал также может быть " +
            "использован как точка входа в Сеть. Терминалы установлены в бетонных колоннах и почти неразрушимы. " +
            "Теоретически.";
        Cost = 1;
    }
}
