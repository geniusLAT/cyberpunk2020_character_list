namespace Cyberpunk2020GameEntities.Equipments.Housing;

public abstract class Housing : Equipment
{
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
}
