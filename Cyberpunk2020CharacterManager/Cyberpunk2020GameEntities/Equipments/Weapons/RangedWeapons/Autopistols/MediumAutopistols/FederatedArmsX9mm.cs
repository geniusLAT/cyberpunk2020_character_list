namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons.Autopistols.MediumAutopistols;

public class FederatedArmsX9mm : MediumAutoPistol
{
    public override string Name { get { return "Federated Arms X-9mm"; } }

    public override int BookIndex { get; set; } = 2;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7) + 1;
    }

    public FederatedArmsX9mm()
    {
        Description = "Надёжное оружие для Соло, используемое в качестве стандартного военного оружия в США и ЕЭС.";

        type = WeaponType.Pistol;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Jacket;
        Avaliability = WeaponAvaliability.Excellent;
        DamageFormula = "2D6+1";
        AmmoType = WeaponAmmoType.Bullet9mm;
        shots = 12;
        RateOfFireInTurn = 2;
        Reliability = WeaponReliability.Standart;
        Range = 50;
        Cost = 300;
    }
}
