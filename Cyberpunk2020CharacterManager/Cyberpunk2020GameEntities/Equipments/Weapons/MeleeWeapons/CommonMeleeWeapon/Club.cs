namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.CommonMeleeWeapon;

public class Club : MeleeWeapon
{
    public override string Name { get { return "Дубинка"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7);
    }

    public Club()
    {
        Description = "";

        type = WeaponType.Melee;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.LongCoat;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "1D6";
        AmmoType = WeaponAmmoType.none;
        shots = 0;
        RateOfFireInTurn = 0;
        Reliability = WeaponReliability.none;
        Range = 1;
        Cost = 0;
    }
}
