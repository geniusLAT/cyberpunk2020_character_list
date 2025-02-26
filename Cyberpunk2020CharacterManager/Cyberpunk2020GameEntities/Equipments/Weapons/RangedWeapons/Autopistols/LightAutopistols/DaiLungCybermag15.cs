namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols.LightAutopistols;

public class DaiLungCybermag15 : LightAutoPistol
{
    public override string Name { get { return "Dai Lung Cybermag 15"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + 1;
    }

    public DaiLungCybermag15()
    {
        Description = "Дешёвая Гонконгская подделка, часто используется бустерами и прочими уличными отбросами.";

        weaponType = WeaponType.Pistol;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.Pocket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "1D6+1";
        AmmoType = WeaponAmmoType.Bullet6mm;
        shots = 10;
        RateOfFireInTurn = 2;
        Reliability =  WeaponReliability.Unreliable;
        Range = 50;
        Cost = 50;
    }
}
