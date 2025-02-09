namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class VideBoard : Equipment
{
    public override string Name { get { return "Видео экран (квадратный фут)"; } }

    public override int BookIndex { get; set; } = 1;

    public VideBoard()
    {
        Description = " монитор с использованием технологии плоских ЖК-дисплеев. " +
            "Большинство видео экранов, не более 30 см, встроено в телевизоры, но у всех " +
            "типов есть входные разъёмы для использования в качестве монитора считывания для" +
            " других электронных товаров. Крупные (50 х 250 см) используются в качестве рекламных вывесок. " +
            "Видео экраны поставляются от 30 квадратных сантиметров.";
        Cost = 100;
    }
}
