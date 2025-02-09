namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class Flashtube : Equipment
{
    public override string Name { get { return "Фонарик"; } }

    public override int BookIndex { get; set; } = 6;

    public Flashtube()
    {
        Description = "вы все знаете, что это такое. Длина луча 2,5-3 метра. " +
            "Можно купить маленький карманные фонарик (1/4 длинны луча) за половину нормальной цены.";
        Cost = 2;
    }
}
