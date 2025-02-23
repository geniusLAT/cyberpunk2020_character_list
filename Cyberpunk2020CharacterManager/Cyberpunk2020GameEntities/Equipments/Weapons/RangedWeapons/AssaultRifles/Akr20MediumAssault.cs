namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.AssaultRifles;

public class Akr20MediumAssault : AssaultRifle
{
    public override string Name { get { return "AKR-20 Medium Assault"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public Akr20MediumAssault()
    {
        Description = "Обновлённый АКМ из пластика и углеродного волокна, " +
            "который распространён в том, что осталось от советского блока.";

        type = WeaponType.Rifle;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "5D6";
        AmmoType = WeaponAmmoType.Bullet5dot56;
        shots = 30;
        RateOfFireInTurn = 30;
        Reliability = WeaponReliability.Standart;
        Range = 400;
        Cost = 450;
    }
}
