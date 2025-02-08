namespace Cyberpunk2020GameEntities.Equipments.Tools;

public class CuttingTorch : Equipment
{
    public override string Name { get { return "Газовый резак"; } }

    public CuttingTorch()
    {
        Description = "обычно кислородноацетиленовая смесь в ручном баллоне, около 30 см в длину. " +
            "Доступны более мощные модели, вплоть до кислородно-термитных копий, в 5-15 раз дороже.";
        Cost = 40;
    }
}
