namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class DermalStapler : Equipment
{
    public override string Name { get { return "Степлер для Кожи"; } }

    public override int BookIndex { get; set; } = 0;

    public DermalStapler()
    {
        Description = " он автоматически сближает края раны и " +
            "зашивает её скобами из стягиваемого органического материала, который растворяется по прошествии времени.";
        Cost = 1000;
    }
}
