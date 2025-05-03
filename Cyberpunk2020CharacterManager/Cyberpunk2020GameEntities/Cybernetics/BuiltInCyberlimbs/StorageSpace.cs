namespace Cyberpunk2020GameEntities.Cybernetics.BuiltInCyberlimbs;

public class StorageSpace : BuiltInCyberlimb
{
    public override string Name { get { return "Место для хранения"; } }

    public StorageSpace()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это пространство для хранения 5х15х5 см с запирающейся крышкой.";
        HumanityLossFormula = "0.5";
        Cost = 50;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 0.5f;
    }
}
