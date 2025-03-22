namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class SoundEditing : CyberAudio
{
    public override string Name { get { return "Редактор звука"; } }

    public SoundEditing()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " эта система позволяет пользователю редактировать отвлекающие шумы или " +
            "снижать определенные звуки. Активация этой системы добавляет +2 к любой проверке " +
            "Осведомлённости относящейся к звуку. Редактирование звука может использоваться в " +
            "сочетании с Усиленным слухом или Расширенным слуховым диапазоном.";
        HumanityLossFormula = "0.5";
        Cost = 150;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
