namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols.LightAutopistols;

public class BudgetArmsC13 : LightAutoPistol
{
    public override string Name { get { return "BudgetArms C-13"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7);
    }

    public BudgetArmsC13()
    {
        Description = "Маломощный пистолет, используемый как скрытое или как \"оружие леди\".";

        type = WeaponType.Pistol;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.Pocket;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "1D6";
        AmmoType = WeaponAmmoType.Bullet5mm;
        shots = 8;
        RateOfFireInTurn = 2;
        Reliability =  WeaponReliability.Standart;
        Range = 50;
        Cost = 75;
    }
}
