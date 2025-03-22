using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class HomingTracer : CyberAudio
{
    public override string Name { get { return "Устройство Слеживания"; } }

    public HomingTracer()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта опция позволяет персонажу отслеживать передачу тонального " +
            "сигнала от внешнего оправителя. Диапазон составляет 1 км. " +
            "Громкость увеличивается по мере приближения пользователя к цели. " +
            "Поставляется с двумя передатчиками, размером и формой C палец. " +
            "Дополнительные передатчики стоят 25eb каждый.";
        HumanityLossFormula = "0.5";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
