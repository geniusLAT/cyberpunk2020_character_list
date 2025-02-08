namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class Logcompass : Equipment
{
    public override string Name { get { return "Лог-компас"; } }

    public Logcompass()
    {
        Description = " вид программируемого инерционного компаса, который" +
            "отслеживает направление твоих перемещений относительно неподвижной опоры или точки";
        Cost = 50;
    }
}
