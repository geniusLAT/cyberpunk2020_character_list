namespace Cyberpunk2020GameEntities.Equipments.Furnishings;

public class NylonCarrybag : Equipment
{
    public override string Name { get { return "Нейлоновая Дорожная Сумка"; } }

    public override int BookIndex { get; set; } = 0;

    public NylonCarrybag()
    {
        Description = " спортивная сумка / сумка 2000х с различными логотипами на выбор. Размеры варьируются.";
        Cost = 5;
    }
}
