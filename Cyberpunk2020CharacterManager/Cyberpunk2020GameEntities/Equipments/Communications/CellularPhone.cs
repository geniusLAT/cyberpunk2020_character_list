namespace Cyberpunk2020GameEntities.Equipments.Communications;

public  class CellularPhone : Equipment
{
    public override string Name { get { return "Сотовый Телефон"; } }

    public override int BookIndex { get; set; } = 3;

    public CellularPhone()
    {
        Description = "Связь в движении, в любом месте в пределах " +
            "досягаемости радиотелефонной приемопередающей сети. " +
            " За обслуживание телефона взимается 100 евродолларов (ED / EB) в месяц.";
        Cost = 400;
    }
}
