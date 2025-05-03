namespace Cyberpunk2020GameEntities.Cybernetics.CybeweaponsBuiltInCyberLimb;

public class GrenadeLauncher : CybeweaponBuiltInCyberLimb
{
    public override string Name { get { return "Гранатомёт"; } }

    public GrenadeLauncher()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "Эта пусковая установка представляет собой модифицированный " +
            "гранатомёт поддержки, расположенный во всплывающем креплении." +
            " Одна граната (ты можешь использовать любой стандартный тип) " +
            "хранится в пусковой установке, второй заряд может быть выпущен " +
            "только после отстрела первого. " +
            "Примечание: стан- чдартное место для хранения вмещает 2 гранаты.";
        HumanityLossFormula = "2D6";
        Cost = 500;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }
}
