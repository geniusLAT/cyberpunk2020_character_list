namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class SlapPatch : Equipment
{
    public override string Name { get { return "Пластырь"; } }

    public override int BookIndex { get; set; } = 2;

    public SlapPatch()
    {
        Description = "небольшая пластиковая накладка, содержащая определенное количество препарата. " +
            "Накладка наносится на кожу, а лекарство впитывается равномерной дозой. " +
            "См. Раздел \"TRAUMA TEAM\" для получения информации о препаратах и ценах." +
            "\r\n\r\n[ФУНКЦИОНАЛ В РАЗРАБОТКЕ]";
        Cost = 0;
    }
}
