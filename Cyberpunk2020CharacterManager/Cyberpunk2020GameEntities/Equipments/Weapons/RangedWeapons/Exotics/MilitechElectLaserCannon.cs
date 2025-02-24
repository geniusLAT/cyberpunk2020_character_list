using Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.AssaultRifles;

namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Exotics;

public class MilitechElectLaserCannon : AssaultRifle
{
    public override string Name { get { return "Militech Elect. LaserCannon"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7);
    }

    public MilitechElectLaserCannon()
    {
        Description = "Специальная военная лазерная пушка, которую мало кто видел. " +
            "Смотри детали в разделе ПвПВ, стр. 108.";

        type = WeaponType.Rifle;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Rare;
        DamageFormula = "1-5D6";
        AmmoType = WeaponAmmoType.none;
        shots = 10;
        RateOfFireInTurn = 2;
        Reliability = WeaponReliability.Unreliable;
        Range = 200;
        Cost = 8000;
    }
}