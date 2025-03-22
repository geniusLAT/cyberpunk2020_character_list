using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class PhoneSplice : CyberAudio
{
    public override string Name { get { return "Телефонное соединение"; } }

    public PhoneSplice()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " улучшенная радиосвязь, это устройство подключено к твоему" +
            " персональному сотовому телефону. На практике это позволяет тебе делать всё то, " +
            "что позволяет делать радиосвязь, но твой телефон должен быть на расстоянии 3 метров от тебя, " +
            "он должен быть уже включен, a номер набран. Аудио соединение обычно используется" +
            " занятыми Корпоративными сотрудниками, которые хотят иметь возможность отвечать на " +
            "звонки даже на совещании. Одним из самых больших преимуществ аудио соединения является" +
            " его дальность - куда бы ты не пошёл, твой телефон будет работать. Даже на луне.";
        HumanityLossFormula = "1";
        Cost = 150;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
