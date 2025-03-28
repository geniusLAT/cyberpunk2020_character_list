﻿namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class RadioLink : CyberAudio
{
    public override string Name { get { return "РадиоКоннектор"; } }

    public RadioLink()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "миниатюрный радиопередатчик, обычно устанавливаемый в основании " +
            "черепа и использующий твои пломбы в качестве антенн. Он активируется при резком" +
            " стискивании зубов. Чтобы говорить, ты просто применяешь субво- калиацию (бормочешь под нос)." +
            " Приём осуществляется одним из двух способов: " +
            "1) Приёмник вибрирует непосредственно на сосцевидном отростке, давая тебе тихий " +
            "голос в затылке, или 2) Связанный C опцией кибероптики," +
            " входящие сообщения высвечиваются в верхнем крае поля зрения в " +
            "виде красных пробегающих букв. С точки зрения игры, радио- коннектор даёт " +
            "тебе возможность общаться с любым приемником на той же частоте в радиусе до 1,6 км." +
            " Также это означает, что время от времени ты будешь получать радиосообщения от других.";
        HumanityLossFormula = "1";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
