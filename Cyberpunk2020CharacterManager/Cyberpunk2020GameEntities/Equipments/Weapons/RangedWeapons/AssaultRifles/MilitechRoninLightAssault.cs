namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.AssaultRifles;

public class MilitechRoninLightAssault : AssaultRifle
{
    public override string Name { get { return "Militech Ronin Light Assault"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public MilitechRoninLightAssault()
    {
        Description = "Лёгкая, универсальная новинка, схожая с \"М-16В\".";

        weaponType = WeaponType.Rifle;
        WeaponAccuracy = +1;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "5D6";
        AmmoType = WeaponAmmoType.Bullet5dot56;
        shots = 35;
        RateOfFireInTurn = 30;
        Reliability = WeaponReliability.VeryReliable;
        Range = 400;
        Cost = 450;
    }
}
