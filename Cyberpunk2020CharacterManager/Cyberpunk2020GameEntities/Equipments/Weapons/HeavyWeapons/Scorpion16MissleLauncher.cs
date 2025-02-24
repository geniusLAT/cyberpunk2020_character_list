namespace Cyberpunk2020GameEntities.Equipments.Weapons.HeavyWeapons;

public class Scorpion16MissleLauncher : Weapon
{
    public override string Name { get { return "Scorpion 16 Missle Launcher"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11)
            + random.Next(1, 11)+ random.Next(1, 11)+ random.Next(1, 11);
    }

    public Scorpion16MissleLauncher()
    {
        Description = "Третье поколение ракетной пусковой установки \"Stinger\"," +
            " это наплечная установка, запускающая одну ракету.";

        type = WeaponType.Heavy;
        WeaponAccuracy = -1;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Rare;
        DamageFormula = "7D10";
        AmmoType = WeaponAmmoType.none;
        shots = 1;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.VeryReliable;
        Range = 1000;
        Cost = 3000;
    }
}
