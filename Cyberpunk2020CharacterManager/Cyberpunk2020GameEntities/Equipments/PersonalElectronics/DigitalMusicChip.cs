namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class DigitalMusicChip : Equipment
{
    public override string Name { get { return "Цифровой Музыкальный Чип)"; } }

    public DigitalMusicChip()
    {
        Description = " от 1 до 6 любимых поп-альбомов (или любой другой музыки) " +
            "запихнутых в полупроводники и пластик. Эти чипы также доступны в формате чтение-запись..";
        Cost = 20;
    }
}
