namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.CommonMeleeWeapon;

public class Knife : MeleeWeapon
{
    public override string Name { get { return "Нож"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7);
    }

    public Knife()
    {
        Description = "";

        type = WeaponType.Melee;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Pocket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "1D6";
        AmmoType = WeaponAmmoType.none;
        shots = 0;
        RateOfFireInTurn = 0;
        Reliability = WeaponReliability.none;
        Range = 1;
        Cost = 1;
        MaxCost = 20;
    }
}
