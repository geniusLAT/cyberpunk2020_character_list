namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class DigitalRecorder : Equipment
{
    public override string Name { get { return "Цифровой диктофон"; } }

    public override int BookIndex { get; set; } = 4;

    public DigitalRecorder()
    {
        Description = " устройство записи звука, использующее технологию чипов данных. Большинство из" +
            " них имеют размер двух, ровно сложенных, книг в мягком переплёте. Некоторые меньше, чем колода карт.";
        Cost = 300;
    }
}
