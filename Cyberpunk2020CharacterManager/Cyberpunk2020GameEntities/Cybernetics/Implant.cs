namespace Cyberpunk2020GameEntities.Cybernetics;

public abstract class Implant : BodyPart
{
    public override bool IsImplant 
    { 
        get {
            return true;
        } 
    }

    public int cost { get; set; }

    public virtual string BarriersForChipIn(Character character)
    {
        return string.Empty;
    }
}
