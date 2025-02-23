namespace Cyberpunk2020GameEntities.Equipments.Security;

public class ScannerPlate : Equipment
{
    public override string Name { get { return "Сканирующая панель"; } }

    public override int BookIndex { get; set; } = 9;

    public ScannerPlate()
    {
        Description = "считывающее устройство для блокировки прикосновением ладони." +
            " Может быть прикреплен к любому типу Блокировки магнитной картой или " +
            "Блокировки голосом, чтобы добавить дополнительный уровень безопасности";
        Cost = 500;
    }
}
