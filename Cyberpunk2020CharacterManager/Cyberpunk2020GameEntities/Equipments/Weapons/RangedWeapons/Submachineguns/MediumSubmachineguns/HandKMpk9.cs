namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Submachineguns.MediumSubmachineguns;

public class HandKMpk9 : MediumSubmachinegun
{
    public override string Name { get { return "H&K MPK-9"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + 1;
    }

    public HandKMpk9()
    {
        Description = "Лёгкий композитный пистолет-пулемёт CO встроенными прицелами. " +
            "Используется многими (Euro Solos) Евро Соло.";

        type = WeaponType.Submachinegun;
        WeaponAccuracy = +1;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "2D6+1";
        AmmoType = WeaponAmmoType.Bullet9mm;
        shots = 35;
        RateOfFireInTurn = 25;
        Reliability = WeaponReliability.Standart;
        Range = 200;
        Cost = 520;
    }
}
