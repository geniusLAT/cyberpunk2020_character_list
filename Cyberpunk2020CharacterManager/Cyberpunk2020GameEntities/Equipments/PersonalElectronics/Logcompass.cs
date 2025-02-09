namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class Logcompass : Equipment
{
    public override string Name { get { return "Лог-компас"; } }

    public override int BookIndex { get; set; } = 3;

    public Logcompass()
    {
        Description = " вид программируемого инерционного компаса, который" +
            "отслеживает направление твоих перемещений относительно неподвижной опоры или точки";
        Cost = 50;
    }
}
