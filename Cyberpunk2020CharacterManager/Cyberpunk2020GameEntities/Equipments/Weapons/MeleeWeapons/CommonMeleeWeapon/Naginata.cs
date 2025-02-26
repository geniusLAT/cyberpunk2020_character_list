namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.CommonMeleeWeapon;

public class Naginata : MeleeWeapon //Nunchaku
{
    public override string Name { get { return "Нагината"; } }

    public override int BookIndex { get; set; } = 6;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public Naginata()
    {
        Description = "";

        weaponType = WeaponType.Melee;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Poor;
        DamageFormula = "3D6";
        AmmoType = WeaponAmmoType.none;
        shots = 0;
        RateOfFireInTurn = 0;
        Reliability = WeaponReliability.none;
        Range = 2;
        Cost = 100;
    }
}
