namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Submachineguns.LightSubmachineguns;

public class UziMiniauto9 : LightSubmachinegun
{
    public override string Name { get { return "Uzi Miniauto 9"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + 1;
    }

    public UziMiniauto9()
    {
        Description = "УЗИ вошёл в 21-й век, полностью пластиковым, " +
            "C электрическим роторным магазином и регулируемым спуском." +
            " Выбор многих Соло отвечающих за безопасность.";

        weaponType = WeaponType.Submachinegun;
        WeaponAccuracy = +1;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "2D6+1";
        AmmoType = WeaponAmmoType.Bullet9mm;
        shots = 30;
        RateOfFireInTurn = 35;
        Reliability = WeaponReliability.VeryReliable;
        Range = 150;
        Cost = 475;
    }
}
