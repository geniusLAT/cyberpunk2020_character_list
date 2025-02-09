namespace Cyberpunk2020GameEntities.Equipments.Vehicles;

public class CHOOH2 : Equipment
{
    public override string Name { get { return "CHOOH2 (галлон, 3,5л)"; } }

    public override int BookIndex { get; set; } = 9;

    public CHOOH2()
    {
        Description = "синтетическое мета-спиртовое топливо. Около 1D6 /3 + 1 " +
            "евро за 3,5л (стоимость сильно колеблется из-за спроса, предложения эко-террористической деятельности).";
        Cost = 1;
        MaxCost = 3;
    }
}
