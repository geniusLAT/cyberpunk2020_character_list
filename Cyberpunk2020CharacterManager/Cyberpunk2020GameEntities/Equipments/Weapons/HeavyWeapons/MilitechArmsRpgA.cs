namespace Cyberpunk2020GameEntities.Equipments.Weapons.HeavyWeapons;

public class MilitechArmsRpgA : Weapon
{
    public override string Name { get { return "Militech Arms RPG-A"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11)
            + random.Next(1, 11)+ random.Next(1, 11);
    }

    public MilitechArmsRpgA()
    {
        Description = "Устанавливаемый на плечо, реактивный пусковой гранатомёт.Массово применялся " +
            "центрально-амери- канских конфликтах под названием \"RPG-A\"";

        weaponType = WeaponType.Heavy;
        WeaponAccuracy = -2;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Rare;
        DamageFormula = "7D10";
        AmmoType = WeaponAmmoType.none;
        shots = 1;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.VeryReliable;
        Range = 750;
        Cost = 1500;
    }
}
