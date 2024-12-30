namespace Cyberpunk2020GameEntities.Cybernetics;

public abstract class BodyPart
{
    public Guid Guid { get; set; } = new Guid();

    public virtual string Name { get { return string.Empty; } }

    public abstract bool IsImplant { get; }

    public int cost { get; set; } = 0;

    public int HumanityLoss { get; set; } = 0;
}
