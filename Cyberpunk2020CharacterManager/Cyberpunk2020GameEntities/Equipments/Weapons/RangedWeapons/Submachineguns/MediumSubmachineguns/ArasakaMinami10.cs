namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Submachineguns.MediumSubmachineguns;

public class ArasakaMinami10 : MediumSubmachinegun
{
    public override string Name { get { return "Arasaka Minami 10"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + 3;
    }

    public ArasakaMinami10()
    {
        Description = "Стандартное оружие службы безопасности \"Arasaka\"," +
            " распространено по всему миру. Хорошее, универсальное оружие.";

        weaponType = WeaponType.Submachinegun;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "2D6+3";
        AmmoType = WeaponAmmoType.Bullet10mm;
        shots = 40;
        RateOfFireInTurn = 20;
        Reliability = WeaponReliability.VeryReliable;
        Range = 200;
        Cost = 500;
    }
}
