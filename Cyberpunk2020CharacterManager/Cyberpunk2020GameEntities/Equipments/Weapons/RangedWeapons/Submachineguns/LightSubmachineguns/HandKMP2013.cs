namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Submachineguns.LightSubmachineguns;

public class HandKMP2013 : LightSubmachinegun
{
    public override string Name { get { return "H&K MP-2013"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + 3;
    }

    public HandKMP2013()
    {
        Description = "Обновление \"Heckler & Koch\" модели \"MP - 5K classic\" " +
            "c использованием сложных пластиков и встроенным глушителем.";

        weaponType = WeaponType.Submachinegun;
        WeaponAccuracy = +1;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "2D6+3";
        AmmoType = WeaponAmmoType.Bullet10mm;
        shots = 35;
        RateOfFireInTurn = 32;
        Reliability = WeaponReliability.Standart;
        Range = 150;
        Cost = 450;
    }
}
