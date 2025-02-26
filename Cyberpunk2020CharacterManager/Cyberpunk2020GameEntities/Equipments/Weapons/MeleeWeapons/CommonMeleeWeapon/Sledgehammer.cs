namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.CommonMeleeWeapon;

public class Sledgehammer : MeleeWeapon
{
    public override string Name { get { return "Кувалда"; } }

    public override int BookIndex { get; set; } = 10;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public Sledgehammer()
    {
        Description = "";

        weaponType = WeaponType.Melee;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "4D6";
        AmmoType = WeaponAmmoType.none;
        shots = 0;
        RateOfFireInTurn = 0;
        Reliability = WeaponReliability.none;
        Range = 1;
        Cost = 20;
    }
}