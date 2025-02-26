namespace Cyberpunk2020GameEntities.Equipments.Weapons.HeavyWeapons;

public class KaF253Flamethrower : Weapon
{
    public override string Name { get { return "K-A F-253 Flamethrower"; } }

    public override int BookIndex { get; set; } = 6;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 11) + random.Next(1, 11);
    }

    public KaF253Flamethrower()
    {
        Description = "Распылитель жидкого напалма. Наспинный и громоздкий." +
            " Наносит дополнительный урон после первого попадания (см. ПвПВ, стр. 110).";

        weaponType = WeaponType.Heavy;
        WeaponAccuracy = -2;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Rare;
        DamageFormula = "2D10+";
        AmmoType = WeaponAmmoType.Bullet20mm;
        shots = 10;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.VeryReliable;
        Range = 50;
        Cost = 1500;
    }
}