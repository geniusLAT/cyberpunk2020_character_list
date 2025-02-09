namespace Cyberpunk2020GameEntities.Equipments.Housing;

public class Housing : Equipment
{
    static Dictionary<string, int> HousingLocation = new Dictionary<string, int>()
    {
        {"Боевая зона",1 },
        {"Умеренная зона", 2},
        {"Корпоративная зона", 4},
        {"зона для должностных лиц", 6},
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
