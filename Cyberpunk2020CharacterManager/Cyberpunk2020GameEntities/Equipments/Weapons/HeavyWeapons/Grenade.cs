namespace Cyberpunk2020GameEntities.Equipments.Weapons.HeavyWeapons;

public class Grenade : Weapon
{
    string lastOptionChosen = string.Empty;

    static Dictionary<string, int> Options = new Dictionary<string, int>()
    {
        {"Осколочная (7D6)",1 },
        {"Зажигательная (4D6 на 3 хода)", 1},
        {"Оглушающие (-5 к оглушению)", 1},
        {"Ослепляющая (Слепота на 4 хода)", 1},
        {"Звуковая (Глухота на 4 хода)", 1},
        {"Газовая", 1}
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
    }

    public override void Add(Character character, Random random)
    {
        Detail += lastOptionChosen;
        Cost *= GetOptionPriceModifier(lastOptionChosen);
        base.Add(character, random);
    }

    public override string Name { get { return "Граната"; } }

    public override int BookIndex { get; set; } = 3;

    public override int GenerateDamage(Random random)
    {
        switch (lastOptionChosen)
        {
            case "Осколочная (7D6)":
                return random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11)
            + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11);
            case "Зажигательная (4D6 на 3 хода)":
                return random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11) + random.Next(1, 11);
            default:
                break;
        }
        return 0;
    }

    public Grenade()
    {
        Description = "Типы включают: " +
            "Осколочные (7D6), " +
            "Зажигательные (4D6 в течении 3 ходов)," +
            " Оглушающие (-5 к оглушению)," +
            " Ослепляющие (Слепота на 4 хода)," +
            " Звуковые (Утрата слуха на 4 хода)," +
            " Газовые (см. ПвПВ (Перестрелка в пятницу вечером) Таблица газов).";

        weaponType = WeaponType.Heavy;
        WeaponAccuracy = 0;
        Concealability = WeaponConcealability.Pocket;
        Avaliability = WeaponAvaliability.Poor;
        DamageFormula = "Зависит от типа";
        AmmoType = WeaponAmmoType.none;
        shots = 1;
        RateOfFireInTurn = 1;
        Reliability = WeaponReliability.VeryReliable;
        Range = 0;
        Cost = 30;
    }
}
