namespace Cyberpunk2020GameEntities.Equipments.Medical;

public class CloneLimbReplacement : Equipment
{
    public override string Name { get { return "Замена конечности на клон"; } }

    public override int BookIndex { get; set; } = 13;

    public CloneLimbReplacement()
    {
        Description = "[ФУНКЦИОНАЛ В РАЗРАБОТКЕ]";
        Cost = 1500;
    }
}
