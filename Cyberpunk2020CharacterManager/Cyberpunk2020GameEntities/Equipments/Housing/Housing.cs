
namespace Cyberpunk2020GameEntities.Equipments.Housing;

public abstract class Housing : Equipment
{
    string lastOptionChosen = string.Empty;

    static Dictionary<string, int> HousingLocation = new Dictionary<string, int>()
    {
        {"Боевая зона (1х цена)",1 },
        {"Умеренная зона (2х цена)", 2},
        {"Корпоративная зона (4х цена)", 4},
        {"зона для должностных лиц (6х цена)", 6},
    };

    public override List<string> GetOptions()
    {
        var result = new List<string>();
        foreach (var item in HousingLocation)
        {
            result.Add(item.Key);
        }
        return result;
    }

    public override int GetOptionPriceModifier(string option)
    {
        var PriceModifier = 1;
        HousingLocation.TryGetValue(option, out PriceModifier);
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
