namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols.LightAutopistols;

public class FederatedArmsX22 : LightAutoPistol
{
    public override string Name { get { return "Federated Arms X-22"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + 1;
    }

    public FederatedArmsX22()
    {
        Description = "Вездесущий дешёвый полимерный \"Полимерный Ван-Шот\". Доступен в дизайнерских расцветках.";

        weaponType = WeaponType.Pistol;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Pocket;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "1D6+1";
        AmmoType = WeaponAmmoType.Bullet6mm;
        shots = 10;
        RateOfFireInTurn = 2;
        Reliability =  WeaponReliability.Standart;
        Range = 50;
        Cost = 150;
    }
}
