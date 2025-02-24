namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.CommonMeleeWeapon;

public class Tonfa : MeleeWeapon //Nunchaku
{
    public override string Name { get { return "Тонфа"; } }

    public override int BookIndex { get; set; } = 5;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public Tonfa()
    {
        Description = "";

        type = WeaponType.Melee;
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
