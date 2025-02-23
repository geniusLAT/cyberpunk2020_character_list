namespace Cyberpunk2020GameEntities.Equipments.Security;

public class RemoteSensors : Equipment
{
    public override string Name { get { return "Датчик дистанционной активации"; } }

    public override int BookIndex { get; set; } = 16;

    public RemoteSensors()
    {
        Description = "";
        Cost = 700;
    }
}
