namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.ExoticMeleeWeapon;

public class KendachiMonoknife : MeleeWeapon
{
    public override string Name { get { return "Kendachi Monoknife"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7);
    }

    public KendachiMonoknife()
    {
        Description = "";

        type = WeaponType.Melee;
        WeaponAccuracy = +1;
        Concealability = WeaponConcealability.Pocket;
        Avaliability = WeaponAvaliability.Poor;
        DamageFormula = "2D6";
        AmmoType = WeaponAmmoType.none;
        shots = 0;
        RateOfFireInTurn = 0;
        Reliability = WeaponReliability.VeryReliable;
        Range = 1;
        Cost = 200;
    }
}
