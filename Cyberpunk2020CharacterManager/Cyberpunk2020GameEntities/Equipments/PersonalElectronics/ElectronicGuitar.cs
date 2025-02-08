namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class ElectronicGuitar : Equipment
{
    public override string Name { get { return "Электрогитара"; } }

    public ElectronicGuitar()
    {
        Description = "больше не классический \"топор\", теперь она легче, " +
            "более гибкая в применении, а иногда даже в не опознаваемой форме." +
            " Она может иметь даже серию клавиш, заменяющих струны и лады.";
        Cost = 100;
        MaxCost = 500;
    }
}
