using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class MicroRecorderLink : CyberAudio
{
    public override string Name { get { return "Коннектор микрорекордера"; } }

    public MicroRecorderLink()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " записывать всё, что слышит пользователь, во" +
            " внутреннее или внешнее (через интерфейсные разъёмы) звукозаписывающее устройство.";
        HumanityLossFormula = "0.5";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
