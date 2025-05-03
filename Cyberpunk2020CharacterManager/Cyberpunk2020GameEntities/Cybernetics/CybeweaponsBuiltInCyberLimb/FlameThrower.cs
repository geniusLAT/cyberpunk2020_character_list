namespace Cyberpunk2020GameEntities.Cybernetics.CybeweaponsBuiltInCyberLimb;

public class FlameThrower : CybeweaponBuiltInCyberLimb
{
    public override string Name { get { return "Огнемёт"; } }

    public FlameThrower()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " Это небольшая пылающая струя под высокого" +
            " давления с дальностью метр и 4 зарядами. Урон " +
            "2D6 в 1-й ход, 1D6 / 2 во 2-й ход и далее. " +
            "Защита мягкой брони уменьшается на 2 единицы за каждый ход горения.";
        HumanityLossFormula = "2D6";
        Cost = 600;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }
}
