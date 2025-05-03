namespace Cyberpunk2020GameEntities.Cybernetics.CybeweaponsBuiltInCyberLimb;

public class WeaponMountAndLink : CybeweaponBuiltInCyberLimb
{
    public override string Name { get { return "Крепление для оружия и коннектор"; } }

    public WeaponMountAndLink()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это тяжёлый жёсткий крепеж устанавливается на нижней стороне кибер-руки," +
            " на внешней стороне бедра или на верхней части плеча. Ты можете прикрепить внешние" +
            " версии стандартного оружия к этому креплению, вставляя их контрольные кабели в " +
            "разъёмы крепления. Ты не можешь носить броню или одежду на конечности во время " +
            "использования крепления. Доступное оружие включает в себя:\n" +
            "   Гранатомёт\n" +
            "   Микро - ракетная пусковая установка \n" +
            "   Пистолет с внешним креплением(Размер зависит от Телосложения)";
        HumanityLossFormula = "3";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 3;
    }
}
