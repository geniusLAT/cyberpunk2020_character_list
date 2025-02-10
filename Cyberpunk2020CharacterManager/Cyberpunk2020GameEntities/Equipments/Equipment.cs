namespace Cyberpunk2020GameEntities.Equipments;

public abstract class Equipment : IComparable<Equipment>
{
    public Guid Guid { get; set; } = new Guid();

    public virtual string Name { get { return string.Empty; } }

    public virtual string Detail { get; set; } = string.Empty;

    public float Cost { get; set; }

    public int? MaxCost { get; set; }

    public int Quantity { get; set; } = 1;

    public string Description { get; set; } = string.Empty;

    public string UserNote { get; set; } = string.Empty;

    //public virtual List<BodyPart>? PotentialParents(Character character)
    //{
    //    return null;
    //}

    public virtual int BookIndex { get; set; }

    public virtual int CompareTo(Equipment other)
    {
        if (other == null) return 1; 
        return this.BookIndex.CompareTo(other.BookIndex); 
    }

    public virtual void Add(Character character, Random random)
    {
        character.equipments.Add(this);
    }

    public virtual void Buy(Character character, Random random,string option = "")
    {
        Add(character, random);
        character.CurrentMoney -= Cost * Quantity * GetOptionPriceModifier(option);

    }

    public virtual List<string> GetOptions()
    {
        return new List<string>();
    }

    public virtual int GetOptionPriceModifier(string option)
    {
        return 1;
    }

    public virtual void ChangeOption(string newOption)
    {

    }
}
