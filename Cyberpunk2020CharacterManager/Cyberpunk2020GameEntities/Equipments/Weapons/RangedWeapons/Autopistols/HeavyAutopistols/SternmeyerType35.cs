namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols.HeavyAutopistols;

public class SternmeyerType35 : HeavyAutoPistol
{
    public override string Name { get { return "Sternmeyer Type 35"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public SternmeyerType35()
    {
        Description = "Прочный, надёжный, с отличной останавливающей способностью." +
            " Ещё один запрещенный ЕЭС продукт из Объединенной Германий.";

        type = WeaponType.Pistol;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "3D6";
        AmmoType = WeaponAmmoType.Bullet11mm;
        shots = 8;
        RateOfFireInTurn = 2;
        Reliability = WeaponReliability.VeryReliable;
        Range = 50;
        Cost = 400;
    }
}
