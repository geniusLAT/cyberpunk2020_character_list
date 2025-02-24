namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.ExoticMeleeWeapon;

public class Spm1Battleglove : MeleeWeapon
{
    public override string Name { get { return "SPM1 Battle glove"; } }

    public override int BookIndex { get; set; } = 2;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }

    public Spm1Battleglove()
    {
        Description = "Тяжёлые рукавицы, покрывающие кисть и предплечье, сочленены с " +
            "искусственными мышцами и гидравликой. Боевая перчатка наносит 3D6 урона сжатием," +
            " 2D6 урона ударом и имеет три разъёма для любого стандартного оружия или опции для " +
            "кибер-рук, кроме Гидравлических Поршней.";

        type = WeaponType.Melee;
        WeaponAccuracy = -2;
        Concealability = WeaponConcealability.CantBeHidden;
        Avaliability = WeaponAvaliability.Poor;
        DamageFormula = "3D6/2D6";
        AmmoType = WeaponAmmoType.none;
        shots = 0;
        RateOfFireInTurn = 0;
        Reliability = WeaponReliability.VeryReliable;
        Range = 1;
        Cost = 900;
    }
}
