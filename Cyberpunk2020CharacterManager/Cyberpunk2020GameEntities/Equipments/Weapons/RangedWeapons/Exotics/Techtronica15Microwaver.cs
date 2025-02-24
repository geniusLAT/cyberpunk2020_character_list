using Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols;

namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Exotics;

public class Techtronica15Microwaver : AutoPistol
{
    public override string Name { get { return "Techtronica 15 Microwaver"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7);
    }

    public Techtronica15Microwaver()
    {
        Description = "Излучатель микроволн размером с фонарик. Смотри детали в разделе ПвПВ, стр. 108.";

        type = WeaponType.Pistol;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Poor;
        DamageFormula = "1D6";
        AmmoType = WeaponAmmoType.none;
        shots = 10;
        RateOfFireInTurn = 2;
        Reliability = WeaponReliability.VeryReliable;
        Range = 20;
        Cost = 400;
    }
}