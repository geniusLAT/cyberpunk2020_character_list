namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols.VeryHeavyAutopistols;

public class Armalite44 : VeryHeavyAutoPistol
{
    public override string Name { get { return "Armalite 44"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + 1;
    }

    public Armalite44()
    {
        Description = "Сейчас является стандартным офицерским " +
            "вспомогательным оружие в армии США, М-2000 хорошо послужил в войнах" +
            " Центральной Америки.";

        type = WeaponType.Pistol;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "4D6+1";
        AmmoType = WeaponAmmoType.Bullet12mm;
        shots = 8;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.VeryReliable;
        Range = 50;
        Cost = 500;
    }
}
