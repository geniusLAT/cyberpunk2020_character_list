namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.AssaultRifles;

public class KalashnikovA80HvyRifle : AssaultRifle
{
    public override string Name { get { return "Kalashnikov A-80 Hvy. Rifle"; } }

    public override int BookIndex { get; set; } = 3;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) 
            + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) +2;
    }

    public KalashnikovA80HvyRifle()
    {
        Description = "Ещё один восстановленный советский проект, с улучшенным прицелом и облегчёнными компонентами.";

        weaponType = WeaponType.Rifle;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "6D6+2";
        AmmoType = WeaponAmmoType.Bullet7dot62;
        shots = 35;
        RateOfFireInTurn = 25;
        Reliability = WeaponReliability.Standart;
        Range = 400;
        Cost = 550;
    }
}
