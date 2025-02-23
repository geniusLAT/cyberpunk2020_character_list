namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Submachineguns.LightSubmachineguns;

public class FedArmsTechAssaultII : LightSubmachinegun
{
    public override string Name { get { return "Fed. Arms Tech Assault II"; } }

    public override int BookIndex { get; set; } = 2;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + 1;
    }

    public FedArmsTechAssaultII()
    {
        Description = "Обновлённая версия почтенного \"Tech Assault I\", " +
            "имеет увеличенный магазин, улучшенный автоматический огонь, не плавится. Честно.";

        type = WeaponType.Submachinegun;
        WeaponAccuracy = +1;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "1D6+1";
        AmmoType = WeaponAmmoType.Bullet6mm;
        shots = 50;
        RateOfFireInTurn = 25;
        Reliability = WeaponReliability.Standart;
        Range = 150;
        Cost = 400;
    }
}
