namespace Cyberpunk2020GameEntities.Cybernetics.CyberAudio;

public class TightBeamRadioLink : CyberAudio
{
    public override string Name { get { return "Линия радиосвязи по прямому лучу"; } }

    public TightBeamRadioLink()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "эта опция позволяет использовать радиосвязь через прямой луч на расстояние до 1,6 км, " +
            "если обе стороны находятся в пределах прямой видимости по отношению друг к другу, и" +
            " не заблокированы никаким объектом толщиной более 30 см.";
        HumanityLossFormula = "1";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
