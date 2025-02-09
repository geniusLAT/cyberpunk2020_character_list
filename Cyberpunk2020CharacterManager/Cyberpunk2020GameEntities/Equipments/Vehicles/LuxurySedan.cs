namespace Cyberpunk2020GameEntities.Equipments.Vehicles;

public class LuxurySedan : Vehicle
{
    public override string Name { get { return "Роскошный седан"; } }

    public override int BookIndex { get; set; } = 7;

    public LuxurySedan()
    {
        Description = "с метаноловым или СНООН2 приводом, эти машины развивают максимальную скорость" +
            " около 145 км в час, бак на 75 литров и шесть сидений.";
        Cost = 40000;
    }
}
