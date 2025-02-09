namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class VideoCam : Equipment, IPotentialUnlimitedCost
{
    public override string Name { get { return "Видеокамера"; } }

    public override int BookIndex { get; set; } = 6;

    public VideoCam()
    {
        Description = "  может быть установлена на гарнитуре, зажиме на плече или на руке в зависимости от" +
            " размера (эти факторы влияют на цену - размер записывае- мого изображения, продолжительность записи и т. д. " +
            "Цена указана для самой недорогой модели для ношения на плече). Звук и изображение обычно записываются на " +
            "ленточную кассету размером с колоду карт или меньше, но ты можешь напрямую подключиться к передающему устройству " +
            "с помощью набора кабелей.";
        Cost = 800;
    }
}
