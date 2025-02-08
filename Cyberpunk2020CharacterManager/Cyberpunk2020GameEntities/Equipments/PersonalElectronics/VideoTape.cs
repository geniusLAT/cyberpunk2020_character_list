namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class VideoTape : Equipment
{
    public override string Name { get { return "Видео плёнка"; } }

    public VideoTape()
    {
        Description = "   для Видеокамеры. Примечание: " +
            "видеокассета 2020х является цифровым носителем высокой " +
            "плотности, способным обрабатывать как аудио, так и визуальное изображение.";
        Cost = 4;
    }
}
