namespace Cyberpunk2020GameEntities.Equipments;

public abstract class Equipment
{
    public Guid Guid { get; set; } = new Guid();

    public virtual string Name { get { return string.Empty; } }

    public int Cost { get; set; }

    public string Description { get; set; } = string.Empty;

    //public virtual List<BodyPart>? PotentialParents(Character character)
    //{
    //    return null;
    //}
}
