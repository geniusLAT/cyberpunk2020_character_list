namespace Cyberpunk2020GameEntities.Equipments.Vehicles;

public abstract class Vehicle : Equipment
{
    string lastOptionChosen = string.Empty;

    static Dictionary<string, int> vehicleOption = new Dictionary<string, int>()
    {
        {"Классический (1х цена)",1 },
        {"Киберуправление (2х цена)", 2}
    };

    public override List<string> GetOptions()
    {
        var result = new List<string>();
        foreach (var item in vehicleOption)
        {
            result.Add(item.Key);
        }
        return result;
    }

    public override int GetOptionPriceModifier(string option)
    {
        var PriceModifier = 1;
        vehicleOption.TryGetValue(option, out PriceModifier);
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
