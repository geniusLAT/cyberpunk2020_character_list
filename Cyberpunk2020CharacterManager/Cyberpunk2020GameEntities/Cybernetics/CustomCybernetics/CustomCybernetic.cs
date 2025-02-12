namespace Cyberpunk2020GameEntities.Cybernetics.CustomCybernetics;

public class CustomCybernetic : Implant
{
    private string _name = "Кастом";

    public void SetName(string name)
    {
        _name = name;
    }

    public override string Name { get { return _name; } }

    public override void GenerateHumanLoss(Random random) {  }

    public CustomCybernetic()
    {
        Description = "";
        Cost = 10;
    }
}
