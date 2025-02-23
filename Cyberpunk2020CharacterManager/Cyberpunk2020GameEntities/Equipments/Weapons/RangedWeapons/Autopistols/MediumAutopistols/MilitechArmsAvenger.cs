namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols.MediumAutopistols;

public class MilitechArmsAvenger : MediumAutoPistol
{
    public override string Name { get { return "Militech Arms Avenger"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + 1;
    }

    public MilitechArmsAvenger()
    {
        Description = "Хорошо сделанный пистолет с неплохой дальностью и точностью. Выбор профи.";

        type = WeaponType.Pistol;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "2D6+1";
        AmmoType = WeaponAmmoType.Bullet9mm;
        shots = 10;
        RateOfFireInTurn = 2;
        Reliability = WeaponReliability.VeryReliable;
        Range = 50;
        Cost = 250;
    }
}
