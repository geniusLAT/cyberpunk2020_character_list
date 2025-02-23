namespace Cyberpunk2020GameEntities.Equipments.Security;

public class TrackingDevice : Equipment
{
    public override string Name { get { return "Устройство Отслеживания"; } }

    public override int BookIndex { get; set; } = 14;

    public TrackingDevice()
    {
        Description = "оборудование, ручное или встроенное в кейс, для " +
            "обнаружения / отслеживания Жучков слежения. На дистанции 1,6 км.";
        Cost = 1000;
    }
}
