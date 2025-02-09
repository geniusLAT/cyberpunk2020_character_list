namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class DataChip : Equipment
{
    public override string Name { get { return "Чип Данных"; } }

    public override int BookIndex { get; set; } = 2;

    public DataChip()
    {
        Description = " носитель информации будущего для хранения цифровой информации. Обычно чипы " +
            "в пластиковой оболочке имеют форму пуговицы, плоских квадратов и треугольных брусков. Все виды могут быть " +
            "прочитаны всеми типами носителей с помощью адаптерных насадок.";
        Cost = 10;
    }
}
