namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class PocketTV : Equipment
{
    public override string Name { get { return "Карманный телевизор"; } }

    public PocketTV()
    {
        Description = " использует монитор с плоским экраном, в корпусе 12 х 12 х 2 см или меньше. " +
            "Принимает большинство станций УКВ и УВЧ.";
        Cost = 80;
    }
}
