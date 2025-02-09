namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class Amplifier : Equipment
{
    public override string Name { get { return "Усилитель"; } }

    public override int BookIndex { get; set; } = 15;

    public Amplifier()
    {
        Description = "смотри Электронные клавишные. (Более подробно об инструментах 2010-20-х можно узнать в дополнении \"Рокербой\".)";
        Cost = 500;
        MaxCost = 1000;
    }
}
