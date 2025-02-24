namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.CommonMeleeWeapon;

public class Switchblade : MeleeWeapon
{
    public override string Name { get { return "Складной нож"; } }

    public override int BookIndex { get; set; } = 8;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) / 2;
    }

    public Switchblade()
    {
        Description = "";

        type = WeaponType.Melee;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Pocket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "1D6/2";
        AmmoType = WeaponAmmoType.none;
        shots = 0;
        RateOfFireInTurn = 0;
        Reliability = WeaponReliability.none;
        Range = 1;
        Cost = 15;
    }
}
