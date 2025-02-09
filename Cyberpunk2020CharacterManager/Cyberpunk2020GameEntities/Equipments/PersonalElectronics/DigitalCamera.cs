namespace Cyberpunk2020GameEntities.Equipments.PersonalElectronics;

public class DigitalCamera : Equipment
{
    public override string Name { get { return "Цифровая камера"; } }

    public override int BookIndex { get; set; } = 5;

    public DigitalCamera()
    {
        Description = " неподвижные изображения оцифро- вываются на чип-картридж. Размером с пачку сигарет.";
        Cost = 150;
    }
}
