namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Submachineguns.HeavySubmachineguns;

public class IngramMac11 : HeavySubmachinegun
{
    public override string Name { get { return "Ingram MAC 11"; } }

    public override int BookIndex { get; set; } = 2;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + 1;
    }

    public IngramMac11()
    {
        Description = "Возможно, является " +
            "наиболее часто используемым Соло пистолетом" +
            " - пулемётом из существующих, \"МPК-11\" может" +
            " быть модифицирован в четырех различных" +
            " вариантах конструкции, в том числе в виде " +
            "Булл - пап, стандартного ПП, штурмового " +
            "карабина и с креплением для гранатомёта.";

        type = WeaponType.Submachinegun;
        WeaponAccuracy = -2;
        Concealability = WeaponConcealability.LongCoat;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "4D6+1";
        AmmoType = WeaponAmmoType.Bullet12mm;
        shots = 20;
        RateOfFireInTurn = 10;
        Reliability = WeaponReliability.Standart;
        Range = 200;
        Cost = 650;
    }
}
