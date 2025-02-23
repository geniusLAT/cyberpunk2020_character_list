namespace Cyberpunk2020GameEntities.Equipments.Weapons;

public abstract class Weapon : Equipment
{
    public WeaponType type { get; set; }

    public int WeaponAccuracy { get; set; }

    public WeaponConcealability Concealability { get; set; }

    public WeaponAvaliability Avaliability { get; set; }

    public string DamageFormula { get; set; } = "0";

    public virtual int GenerateDamage(Random random) { return 0; }

    public WeaponAmmoType AmmoType { get; set; }

    public int shots { get; set; }

    public int RateOfFireInTurn { get; set; }

    public WeaponReliability Reliability { get; set; }

    public int Range { get; set; }
}
