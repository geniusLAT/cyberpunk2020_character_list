namespace Cyberpunk2020GameEntities.Equipments.Groceries;

public class Kibble : Equipment
{
    public override string Name { get { return "Киббл (на неделю)"; } }

    public override int BookIndex { get; set; } = 0;

    public Kibble()
    {
        Description = "производимое в массовом порядке питательное вещество, которое удовлетворяет большинству требований к питанию, " +
            "но имеет тенденцию выглядеть, пахнуть и иметь вкус, как сухой корм для домашних животных," +
            " от которого оно получило свое название.";
        Cost = 50;
    }
}
