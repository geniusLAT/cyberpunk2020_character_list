namespace Cyberpunk2020GameEntities.Equipments.Weapons.MeleeWeapons.ExoticMeleeWeapon;

public class KendachiMonoknife : MeleeWeapon
{
    string lastOptionChosen = string.Empty;

    static Dictionary<string, float> Options = new Dictionary<string, float>()
    {
        {"Танто",1f },
        {"Нагината", 1.5f}
    };

    public override List<string> GetOptions()
    {
        var result = new List<string>();
        foreach (var item in Options)
        {
            result.Add(item.Key);
        }
        return result;
    }

    public override void ChangeOption(string newOption)
    {
        lastOptionChosen = newOption;
        if (lastOptionChosen == "Нагината")
        {
            Cost = 300;
            Range = 2;
            Concealability = WeaponConcealability.CantBeHidden;
        }
        else
        {
            Cost = 200;
            Range = 1;
            Concealability = WeaponConcealability.Pocket;
        }
    }

    public override void Add(Character character, Random random)
    {
        Detail += lastOptionChosen;
        base.Add(character, random);
    }
    public override string Name { get { return "Kendachi Monoknife"; } }

    public override int BookIndex { get; set; } = 0;

    public override int GenerateDamage(Random random)
    {
        return random.Next(1, 7) + random.Next(1, 7);
    }

    public KendachiMonoknife()
    {
        Description = "Односторонний кристаллический клинок. Невероятно острый." +
           " В японском стиле \"танто\". " +
           "Также доступны в форме \"нагината\" за дополнительные 100.00";

        weaponType = WeaponType.Melee;
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
