namespace Cyberpunk2020GameEntities.Equipments.Weapons.HeavyWeapons;

public class Mine : Weapon
{
    public override string Name { get { return "Мина"; } }

    public override int BookIndex { get; set; } = 4;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11);
    }

    public Mine()
    {
        Description = "Может быть взорвана таймером, натяжением растяжки, сигналом или датчиком движения.";

        weaponType = WeaponType.Heavy;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Poor;
        DamageFormula = "4D10";
        AmmoType = WeaponAmmoType.Bullet20mm;
        shots = 10;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.VeryReliable;
        Range = 0;
        Cost = 350;
    }
}