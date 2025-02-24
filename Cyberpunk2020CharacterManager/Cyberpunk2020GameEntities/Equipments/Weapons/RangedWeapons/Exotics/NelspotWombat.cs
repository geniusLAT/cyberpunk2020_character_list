using Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols;

namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Exotics;

public class NelspotWombat : AutoPistol
{
    public override string Name { get { return "Nelspot \"Wombat\""; } }

    public override int BookIndex { get; set; } = 4;

    public override int GenerateDamage(Random random)
    {
        return 0;
    }

    public NelspotWombat()
    {
        Description = "Пейнтбольное ружье из ада." +
            " Может стрелять кислотой, краской, препаратами, ядом. " +
            "Смотри детали в разделе ПвПВ, стр. 108.";

        type = WeaponType.Pistol;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "Вещество";
        AmmoType = WeaponAmmoType.none;
        shots = 20;
        RateOfFireInTurn = 2;
        Reliability = WeaponReliability.Unreliable;
        Range = 40;
        Cost = 200;
    }
}