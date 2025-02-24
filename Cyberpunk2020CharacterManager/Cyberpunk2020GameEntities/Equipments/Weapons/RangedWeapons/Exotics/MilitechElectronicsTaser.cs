using Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols;

namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Exotics;

public class MilitechElectronicsTaser : AutoPistol
{
    public override string Name { get { return "Militech Electronics Taser"; } }

    public override int BookIndex { get; set; } = 5;

    public override int GenerateDamage(Random random)
    {
        return 0;
    }

    public MilitechElectronicsTaser()
    {
        Description = "Шокер. Размером примерно с ручной фонарик. Смотри детали в разделе ПвПВ, стр. 107.";

        type = WeaponType.Pistol;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "Оглушение";
        AmmoType = WeaponAmmoType.none;
        shots = 10;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.Standart;
        Range = 10;
        Cost = 60;
    }
}