namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class DigitalChipPlayer : Equipment
{
    public override string Name { get { return "Проигрыватель цифровых чипов"; } }

    public DigitalChipPlayer()
    {
        Description = "  проигрывает чипы аудио и видео записей. " +
            "Ты должен подключать их к видео экрану для воспроизведе- ния видео " +
            "дорожки с цифрового чипа.";
        Cost = 150;
    }
}
