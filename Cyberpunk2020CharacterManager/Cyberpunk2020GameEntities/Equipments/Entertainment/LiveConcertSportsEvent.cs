namespace Cyberpunk2020GameEntities.Equipments.Entertainment;

public class LiveConcertSportsEvent : Equipment
{
    public override string Name { get { return "Живой концерт/Спорт. мероприятие"; } }

    public override int BookIndex { get; set; } = 3;

    public LiveConcertSportsEvent()
    {
        Description = "";
        Cost = 50;
    }
}
