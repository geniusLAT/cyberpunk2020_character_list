namespace Cyberpunk2020GameEntities.Equipments.Weapons.HeavyWeapons;

public class BarretArasakaLight20mm : Weapon
{
    public override string Name { get { return "Barret Arasaka Light 20mm"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11);
    }

    public BarretArasakaLight20mm()
    {
        Description = "Фаворит охотников на киберпсихов. Почти 2 метра в" +
            " длину, эта \"пушка\" стреляет снарядами из обеднённого урана" +
            " со сверхзвуковой скоростью. Тяжелый бронебойный подкалиберный " +
            "снаряд повреждает броню на 2 пункта за попадание.";

        weaponType = WeaponType.Heavy;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Rare;
        DamageFormula = "4D10AP";
        AmmoType = WeaponAmmoType.Bullet20mm;
        shots = 10;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.VeryReliable;
        Range = 450;
        Cost = 2000;
    }
}
