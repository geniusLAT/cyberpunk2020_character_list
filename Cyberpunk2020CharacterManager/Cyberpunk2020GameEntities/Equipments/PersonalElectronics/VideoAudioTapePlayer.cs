﻿namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class VideoAudioTapePlayer : Equipment
{
    public override string Name { get { return "Видео / Аудио ленточный проигрыватель"; } }

    public override int BookIndex { get; set; } = 7;

    public VideoAudioTapePlayer()
    {
        Description = "  это устройств проигрывает ленточные кассеты C видеокамер, также множество старомодных аудио - кассет.";
        Cost = 40;
    }
}
