namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols.MediumAutopistols;

public class DaiLungStreetmaster : MediumAutoPistol
{
    public override string Name { get { return "Dai Lung Streetmaster"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + 3;
    }

    public DaiLungStreetmaster()
    {
        Description = "Ещё один дешевый Dai Lung, сконструированный для Улиц.";

        weaponType = WeaponType.Pistol;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "2D6+3";
        AmmoType = WeaponAmmoType.Bullet10mm;
        shots = 12;
        RateOfFireInTurn = 2;
        Reliability = WeaponReliability.Unreliable;
        Range = 50;
        Cost = 250;
    }
}
