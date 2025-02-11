namespace Cyberpunk2020GameEntities.Equipments.Entertainment;

public class Movie : Equipment
{
    public override string Name { get { return "Кинофильм"; } }

    public override int BookIndex { get; set; } = 0;

    public Movie()
    {
        Description = "";
        Cost = 10;
    }
}
