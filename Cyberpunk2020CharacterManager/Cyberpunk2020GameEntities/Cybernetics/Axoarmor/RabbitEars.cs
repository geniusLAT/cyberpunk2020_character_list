using Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

namespace Cyberpunk2020GameEntities.Cybernetics.Axoarmor;

public class RabbitEars : Implant, OpticalModule
{
    public override string Name { get { return $"Sensory Extension (Сенсорный отросток)"; } }

    public RabbitEars()
    {
        SurgeryCode = SurgeryCode.Minor;
        Description = "то плоские антенны и оптические крепления длиной от 2,5 до 5 см. " +
            "В наконечнике установлен один кибер-оптический модуль и микрофон, что позволяет " +
            "тебе подсматривать за угол, не подставляя всё своё тело на линию огня." +
            " Сенсорные \"Усики\" обычно устанавливаются на голове или на верхнем отделе позвоночника.";
        HumanityLossFormula = "3D6";
        Cost = 500;
        OptionsAlloweded = 4;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
    }
}
