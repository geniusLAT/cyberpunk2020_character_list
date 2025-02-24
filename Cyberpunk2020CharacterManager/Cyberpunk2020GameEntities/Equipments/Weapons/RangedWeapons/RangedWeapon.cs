namespace Cyberpunk2020GameEntities.Equipments.Weapons.RangedWeapons;

public abstract class RangedWeapon : Weapon
{
    string lastOptionChosen = string.Empty;

    static Dictionary<string, int> Options = new Dictionary<string, int>()
    {
        {"Стандарт (1х цена)",1 },
        {"Умное (2х цена)", 2}
    };

    public override List<string> GetOptions()
    {
        if(type == WeaponType.Heavy)
        {
            return new List<string>();
        }

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
