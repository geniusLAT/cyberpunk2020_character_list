namespace Cyberpunk2020GameEntities.Equipments.Fashion;

public abstract class FashionStyle : Equipment
{
    string lastOptionChosen = string.Empty;

    static Dictionary<string, int> Options = new Dictionary<string, int>()
    {
        {"Универсальный шик (1х цена)",1 },
        {"Досуговая одежда (2х цена)", 2},
        {"Деловая одежда (3х цена)", 3},
        {"Высокая мода (4х цена)", 4},
        {"Городское сияние (2х цена)", 2},
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
