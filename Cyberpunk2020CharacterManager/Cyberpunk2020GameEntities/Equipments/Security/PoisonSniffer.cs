namespace Cyberpunk2020GameEntities.Equipments.Security;

public class PoisonSniffer : Equipment
{
    public override string Name { get { return "Распознаватель ядов"; } }

    public override int BookIndex { get; set; } = 6;

    public PoisonSniffer()
    {
        Description = "может быть настроен для проверки воздуха или жидкости на " +
            "наличие определенного яда. В противном случае он просто предупредит тебя " +
            "о наличии посторонних веществ. Точность 85%.";
        Cost = 1500;
    }
}
