namespace Cyberpunk2020GameEntities.Equipments.Security;

public class JammingTransmitter : Equipment
{
    public override string Name { get { return "Генератор помех"; } }

    public override int BookIndex { get; set; } = 8;

    public JammingTransmitter()
    {
        Description = " обычно поставляется в 2 или 3 крупных кейсах, но может заполнить весь фургон. " +
            "Забивает помехами электромагнитные передачи в области 300 метров " +
            "(включая сотовые телефоны и некоторые кибер-программы).";
        Cost = 500;
    }
}
