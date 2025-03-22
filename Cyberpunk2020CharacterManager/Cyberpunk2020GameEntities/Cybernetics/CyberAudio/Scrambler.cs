namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class Scrambler : CyberAudio
{
    public override string Name { get { return "ЕСМ скремблер"; } }

    public Scrambler()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "имплантат улучшает радио или телефоное соединение с помощью шифратора, " +
            "поэтому его нельзя прослушать. В игровых терминах это делает все радио или телефонные " +
            "соединения приватными, если только у перехватчика нет блока дешифратора и у него много времени.";
        HumanityLossFormula = "0.5";
        Cost = 150;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
