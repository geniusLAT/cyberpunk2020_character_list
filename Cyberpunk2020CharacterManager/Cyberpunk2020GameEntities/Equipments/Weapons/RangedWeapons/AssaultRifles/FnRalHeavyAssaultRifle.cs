namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.AssaultRifles;

public class FnRalHeavyAssaultRifle : AssaultRifle
{
    public override string Name { get { return "FN-RAL Heavy Assault Rifle"; } }

    public override int BookIndex { get; set; } = 2;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) 
            + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) +2;
    }

    public FnRalHeavyAssaultRifle()
    {
        Description = "Стандартное штурмовое оружие НАТО для работы на поле боя." +
            " Конструкция Булл-пап, телескопический приклад.";

        type = WeaponType.Rifle;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "6D6+2";
        AmmoType = WeaponAmmoType.Bullet7dot62;
        shots = 30;
        RateOfFireInTurn = 30;
        Reliability = WeaponReliability.VeryReliable;
        Range = 400;
        Cost = 600;
    }
}
