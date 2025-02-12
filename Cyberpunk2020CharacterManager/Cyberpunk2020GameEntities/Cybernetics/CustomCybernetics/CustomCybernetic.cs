namespace Cyberpunk2020GameEntities.Cybernetics.CustomCybernetics;

public class CustomCybernetic : Implant
{
    public void SetName(string name)
    {
        RealName = name;
    }

    public override string Name { get { return RealName; } }

    public override void GenerateHumanLoss(Random random) {  }

    public CustomCybernetic()
    {
        RealName = "Кастом";
        Description = "";
        Cost = 10;
    }
}
