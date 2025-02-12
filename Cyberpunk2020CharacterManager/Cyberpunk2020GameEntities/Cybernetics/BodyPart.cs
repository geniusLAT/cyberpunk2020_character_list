namespace Cyberpunk2020GameEntities.Cybernetics;

public abstract class BodyPart
{
    public Guid Guid { get; set; } = new Guid();

    //TODO remove that field
    public string RealName { get; set; }

    public virtual string Name { get { return string.Empty; } }

    public abstract bool IsImplant { get; }

    public int Cost { get; set; }

    public Guid BodyPlace { get; set; }

    public float HumanityLoss { get; set; } = 0;

    public virtual List<BodyPart>? PotentialParents(Character character)
    {
        return null;
    }

    public string type { get
        {
            return this.GetType().FullName;
        }
    }
}
