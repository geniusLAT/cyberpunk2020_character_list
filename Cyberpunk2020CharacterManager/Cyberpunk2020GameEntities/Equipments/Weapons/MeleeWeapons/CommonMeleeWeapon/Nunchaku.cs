namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.CommonMeleeWeapon;

public class Nunchaku : MeleeWeapon //Nunchaku
{
    public override string Name { get { return "Нунчаки"; } }

    public override int BookIndex { get; set; } = 4;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public Nunchaku()
    {
        Description = "";

        weaponType = WeaponType.Melee;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.LongCoat;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "3D6";
        AmmoType = WeaponAmmoType.none;
        shots = 0;
        RateOfFireInTurn = 0;
        Reliability = WeaponReliability.none;
        Range = 1;
        Cost = 15;
    }
}
