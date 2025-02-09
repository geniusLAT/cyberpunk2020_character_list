namespace Cyberpunk2020GameEntities.Equipments.Surveillance;

public class LightBoosterGoggles : Equipment
{
    public override string Name { get { return "Усиливающие свет очки"; } }

    public override int BookIndex { get; set; } = 3;

    public LightBoosterGoggles()
    {
        Description = "усилители света, усиливающие окружающий свет для ночного видения с помощью технологии" +
            " «Starlite». При внезапном увеличении уровня света, очки могут ошеломить. С помощью настройки " +
            "(Сложная задача (20)) они также могут обнаруживать активные ИК-лучи.";
        Cost = 200;
    }
}
