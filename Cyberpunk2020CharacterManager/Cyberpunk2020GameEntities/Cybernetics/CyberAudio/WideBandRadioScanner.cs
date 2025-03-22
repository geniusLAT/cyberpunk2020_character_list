namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class WideBandRadioScanner : CyberAudio
{
    public override string Name { get { return "Широкополосный радио сканер"; } }

    public WideBandRadioScanner()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта опция автоматически сканирует все основные группы связи полиции, " +
            "пожарной охраны, скорой помощи и Trauma Team. Пользователь может настроить этот " +
            "сканер так, чтобы он охватывал одну конкретную полосу, загружая любые входящие " +
            "сообщения на свою внутреннюю радиосвязь или во всплывающее окно Times SquareTM";
        HumanityLossFormula = "2";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 2;
    }
}
