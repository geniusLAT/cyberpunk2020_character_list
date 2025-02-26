namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Exotics;

public class EagleTechTomcatCBow : RangedWeapon
{
    public override string Name { get { return "EagleTech \"Tomcat\" C-Bow"; } }

    public override int BookIndex { get; set; } = 6;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public EagleTechTomcatCBow()
    {
        Description = "Гиростабилизированный составной лук. Тихий и смертоносный.";

        weaponType = WeaponType.Exotic;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "4D6";
        AmmoType = WeaponAmmoType.Arrow;
        shots = 12;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.VeryReliable;
        Range = 150;
        Cost = 150;
    }
}