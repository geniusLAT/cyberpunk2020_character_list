namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Shotguns;

public class ArasakaRapidAssault12 : Shotgun
{
    public override string Name { get { return "Arasaka Rapid Assault 12"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public ArasakaRapidAssault12()
    {
        Description = "Автоматический дробовик высокой мощности со смертоносной огневой мощью. " +
            "Используется \"Arasaka\" по всему миру ещё одна веская причина избегать \"Парней в Чёрном\".";

        type = WeaponType.Shotgun;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Common;
        DamageFormula = "4D6";
        AmmoType = WeaponAmmoType.shotshell;
        shots = 20;
        RateOfFireInTurn = 10;
        Reliability = WeaponReliability.Standart;
        Range = 50;
        Cost = 900;
    }
}
