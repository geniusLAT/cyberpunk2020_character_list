namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class HoloGenerator : Equipment
{
    public override string Name { get { return "Голографический генератор"; } }

    public HoloGenerator()
    {
        Description = " небольшой ящик (приблизительно 10 x 15 x 5 см) проецирует голографическое изображение со сменного чипа. " +
            "Генератор совместим с чипами большинства цифровых камер. Может быть соединён с цифровым рекордером / плеером.";
        Cost = 500;
    }
}
