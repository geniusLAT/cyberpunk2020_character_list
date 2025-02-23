namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class FirstAidKit : Equipment
{
    public override string Name { get { return "Комплект первой помощи"; } }

    public override int BookIndex { get; set; } = 6;

    public FirstAidKit()
    {
        Description = "обычная домашняя аптечка. Она имеет повязки, антисептики и простое обезболивающее.";
        Cost = 10;
    }
}
