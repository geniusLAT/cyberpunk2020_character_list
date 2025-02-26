namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.CommonMeleeWeapon;

public class Shiriken : MeleeWeapon //Nunchaku
{
    public override string Name { get { return "Сюрикен"; } }

    public override int BookIndex { get; set; } = 7;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) / 3;
    }

    public Shiriken()
    {
        Description = "";

        weaponType = WeaponType.Melee;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Pocket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "1D6/3";
        AmmoType = WeaponAmmoType.none;
        shots = 0;
        RateOfFireInTurn = 0;
        Reliability = WeaponReliability.none;
        Range = 0;
        Cost = 2;
        MaxCost = 3;
    }
}
