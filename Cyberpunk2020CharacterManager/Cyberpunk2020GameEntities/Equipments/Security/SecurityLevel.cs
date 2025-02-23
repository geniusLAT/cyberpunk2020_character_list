namespace Cyberpunk2020GameEntities.Equipments.Security;

public abstract class SecurityLevel : Equipment
{
    string lastOptionChosen = string.Empty;

    static Dictionary<string, int> Options = new Dictionary<string, int>()
    {
        {"Низкая безопасность (1х цена, сложность 15)",1 },
        {"Средняя безопасность (2х цена, сложность 20)", 2},
        {"Высокая безопасность (3х цена, сложность 25)", 3},
        {"Максимальная безопасность (4х цена)", 4},
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

    public override int GetOptionPriceModifier(string option)
    {
        var PriceModifier = 1;
        Options.TryGetValue(option, out PriceModifier);
        return PriceModifier;
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
}
