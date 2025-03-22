namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class LevelDamper : CyberAudio
{
    public override string Name { get { return "Демпфер уровня"; } }

    public LevelDamper()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " эта система автоматически компенсирует громкие звуки, такие как удары " +
            "оглушающей бомбы или звуковое оружие. Персонажи с этой опцией могут игнорировать " +
            "все эффекты этого оружия.";
        HumanityLossFormula = "0.5";
        Cost = 300;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
