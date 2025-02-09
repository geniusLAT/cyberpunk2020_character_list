namespace Cyberpunk2020GameEntities.Equipments.Groceries;

public class FreshFood : Equipment
{
    public override string Name { get { return "Натуральная еда (на неделю)"; } }

    public override int BookIndex { get; set; } = 3;

    public FreshFood()
    {
        Description = "ты знаешь, что это такое. Ну, по крайней мере, ты встречал кого-то, кто ел это.";
        Cost = 300;
    }
}
