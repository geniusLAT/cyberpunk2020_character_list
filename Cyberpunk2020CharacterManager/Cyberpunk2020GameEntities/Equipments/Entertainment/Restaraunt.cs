namespace Cyberpunk2020GameEntities.Equipments.Entertainment;

public abstract class Restaraunt : Equipment
{
    string lastOptionChosen = string.Empty;

    static Dictionary<string, int> RestarauntLevel = new Dictionary<string, int>()
    {
        {"Сносная (1х цена)",1 },
        {"Хорошая (2х цена)", 2},
        {"Отличная (3х цена)", 3}
    };

    public override List<string> GetOptions()
    {
        var result = new List<string>();
        foreach (var item in RestarauntLevel)
        {
            result.Add(item.Key);
        }
        return result;
    }

    public override int GetOptionPriceModifier(string option)
    {
        var PriceModifier = 1;
        RestarauntLevel.TryGetValue(option, out PriceModifier);
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
