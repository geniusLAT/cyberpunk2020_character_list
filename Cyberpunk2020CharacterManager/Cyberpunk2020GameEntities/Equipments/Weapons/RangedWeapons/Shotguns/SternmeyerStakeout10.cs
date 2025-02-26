namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Shotguns;

public class SternmeyerStakeout10 : Shotgun
{
    public override string Name { get { return "Sternmeyer Stakeout 10"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public SternmeyerStakeout10()
    {
        Description = "Лёгкий патрульный дробовик, используемый городскими полицейскими департаментами.";

        weaponType = WeaponType.Shotgun;
        WeaponAccuracy = -2;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Rare;
        DamageFormula = "4D6";
        AmmoType = WeaponAmmoType.shotshell;
        shots = 10;
        RateOfFireInTurn = 2;
        Reliability = WeaponReliability.Standart;
        Range = 50;
        Cost = 450;
    }
}
