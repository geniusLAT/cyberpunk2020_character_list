namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.ExoticMeleeWeapon;

public class KendachiMonoKatana : MeleeWeapon
{
    public override string Name { get { return "Kendachi MonoKatana"; } }

    public override int BookIndex { get; set; } = 1;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public KendachiMonoKatana()
    {
        Description = "Длинная версиямономолекулярного клинка. " +
            "Напоминает высокотехнологичную \"катану\" с молочным, почти прозрачным лезвием";

        type = WeaponType.Melee;
        WeaponAccuracy = +1;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Rare;
        DamageFormula = "4D6";
        AmmoType = WeaponAmmoType.none;
        shots = 0;
        RateOfFireInTurn = 0;
        Reliability = WeaponReliability.VeryReliable;
        Range = 1;
        Cost = 600;
    }
}
