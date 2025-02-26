namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.CommonMeleeWeapon;

public class Chainsaw : MeleeWeapon
{
    public override string Name { get { return "Бензопила"; } }

    public override int BookIndex { get; set; } = 11;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public Chainsaw()
    {
        Description = "";

        weaponType = WeaponType.Melee;
        WeaponAccuracy = -3;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "4D6";
        AmmoType = WeaponAmmoType.none;
        shots = 0;
        RateOfFireInTurn = 0;
        Reliability = WeaponReliability.none;
        Range = 2;
        Cost = 80;
    }
}