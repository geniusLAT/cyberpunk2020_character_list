namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols.VeryHeavyAutopistols;

public class ColtAmtModel2000 : VeryHeavyAutoPistol
{
    public override string Name { get { return "Colt AMT Model 2000"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + 1;
    }

    public ColtAmtModel2000()
    {
        Description = "Разработанный для испытаний в качестве альтернативного " +
            "вспомогательного оружия армии США 1998 года..";

        weaponType = WeaponType.Pistol;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "4D6+1";
        AmmoType = WeaponAmmoType.Bullet12mm;
        shots = 8;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.Standart;
        Range = 50;
        Cost = 450;
    }
}
