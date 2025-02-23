namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Submachineguns.HeavySubmachineguns;

public class StrenmeyerSmg21 : HeavySubmachinegun
{
    public override string Name { get { return "Strenmeyer SMG 21"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public StrenmeyerSmg21()
    {
        Description = "Лучшая позиция \"Sternmeyer\" антитеррористической категории, " +
            "широким использованием в командах \"C - SWAT\" и \"Psycho Squads\".";

        type = WeaponType.Submachinegun;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.LongCoat;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "3D6";
        AmmoType = WeaponAmmoType.Bullet11mm;
        shots = 30;
        RateOfFireInTurn = 15;
        Reliability = WeaponReliability.VeryReliable;
        Range = 200;
        Cost = 500;
    }
}
