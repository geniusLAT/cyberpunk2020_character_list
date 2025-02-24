using Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols;

namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Exotics;

public class EnertexAkmPowerSquirt : AutoPistol
{
    public override string Name { get { return "Enertex AKM Power Squirt"; } }

    public override int BookIndex { get; set; } = 3;

    public override int GenerateDamage(Random random)
    {
        return 0;
    }

    public EnertexAkmPowerSquirt()
    {
        Description = "Водяной пистолет. Да, мощный водяной пистолет." +
            " Прежде чем рассмеяться, посмотри детали в разделе ПвПВ, стр. 108.";

        type = WeaponType.Pistol;
        WeaponAccuracy = -2;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "Вещество";
        AmmoType = WeaponAmmoType.none;
        shots = 50;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.VeryReliable;
        Range = 10;
        Cost = 15;
    }
}