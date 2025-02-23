namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class Cryotank : Equipment
{
    public override string Name { get { return "Криокамера"; } }

    public override int BookIndex { get; set; } = 3;

    public Cryotank()
    {
        Description = "усовершенствованная замораживающая ёмкость. " +
            "Крио-камера охлаждает тело до уровня консервации, в то время" +
            " как аппараты жизнеобеспечения поддерживают поток крови / кислорода." +
            " Предназначены для фиксации умирающего тела в относительном стазисе.";
        Cost = 100000;
    }
}
