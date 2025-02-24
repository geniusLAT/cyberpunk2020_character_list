namespace Cyberpunk2020GameEntities.Equipments.Weapons.HeavyWeapons;

public class C6PlasticExplosive : Weapon
{
    public override string Name { get { return "C-6 Plastic Explosive (1 кг)"; } }

    public override int BookIndex { get; set; } = 4;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) 
            + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11);
    }

    public C6PlasticExplosive()
    {
        Description = "Блок серого пластика, может быть взорван таймером, натяжением растяжки или сигналом.";

        type = WeaponType.Heavy;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Pocket;
        Avaliability = WeaponAvaliability.Poor;
        DamageFormula = "8D10";
        AmmoType = WeaponAmmoType.Bullet20mm;
        shots = 10;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.VeryReliable;
        Range = 0;
        Cost = 100;
    }
}