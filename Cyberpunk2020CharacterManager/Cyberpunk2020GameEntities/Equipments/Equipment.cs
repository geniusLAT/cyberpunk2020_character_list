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

    public virtual void Add(Character character, Random random)
    {
        character.equipments.Add(this);
    }

    public virtual void Buy(Character character, Random random)
    {
        Add(character, random);
        character.CurrentMoney -= Cost;
    }
}
