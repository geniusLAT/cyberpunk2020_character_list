using Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols;

namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Exotics;

public class AvanteP1135Needlegun : AutoPistol
{
    public override string Name { get { return "Avante P-1135 Needlegun"; } }

    public override int BookIndex { get; set; } = 2;

    public override int GenerateDamage(Random random)
    {
        return 0;
    }

    public AvanteP1135Needlegun()
    {
        Description = "Лёгкий, пластиковый, мощная пневматика. " +
            "Может быть заправлен препаратами или ядом. Смотри детали в разделе ПВПВ, стр. 107.";

        type = WeaponType.Pistol;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Pocket;
        Avaliability = WeaponAvaliability.Poor;
        DamageFormula = "Вещество";
        AmmoType = WeaponAmmoType.Needle;
        shots = 15;
        RateOfFireInTurn = 2;
        Reliability = WeaponReliability.Standart;
        Range = 40;
        Cost = 200;
    }
}