namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols.HeavyAutopistols;

public class BudgetArmsAuto3 : HeavyAutoPistol
{
    public override string Name { get { return "BudgetArms Auto 3"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public BudgetArmsAuto3()
    {
        Description = "Оно дешёвое. Оно мощное. Иногда взрывается. Чего ещё ты хотел?";

        type = WeaponType.Pistol;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "3D6";
        AmmoType = WeaponAmmoType.Bullet11mm;
        shots = 8;
        RateOfFireInTurn = 2;
        Reliability = WeaponReliability.Unreliable;
        Range = 50;
        Cost = 350;
    }
}
