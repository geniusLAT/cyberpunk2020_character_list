namespace Cyberpunk2020GameEntities.Equipments.Housing;

public class HotelRoom : Housing
{
    public override string Name { get { return "Номер отеля (за ночь)"; } }

    public override int BookIndex { get; set; } = 1;

    public HotelRoom()
    {
        Description = string.Empty;
        Cost = 100;
    }
}
