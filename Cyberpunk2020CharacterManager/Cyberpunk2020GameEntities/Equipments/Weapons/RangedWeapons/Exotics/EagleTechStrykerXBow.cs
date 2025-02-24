namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Exotics;

public class EagleTechStrykerXBow : RangedWeapon
{
    public override string Name { get { return "EagleTech \"Stryker\" X-Bow"; } }

    public override int BookIndex { get; set; } = 6;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + 3;
    }

    public EagleTechStrykerXBow()
    {
        Description = "Арбалет из пластика и биметалла. Тихо, смертоносно, и " +
            "обычно ты получаешь свои боеприпасы назад.";

        type = WeaponType.Exotic;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "3D6 + 3";
        AmmoType = WeaponAmmoType.CrossbowBolt;
        shots = 12;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.VeryReliable;
        Range = 50;
        Cost = 220;
    }
}