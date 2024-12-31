namespace Cyberpunk2020GameEntities.Cybernetics;

public abstract class Implant : BodyPart
{
    public SurgeryCode SurgeryCode { get; set; }

    public override bool IsImplant 
    { 
        get {
            return true;
        } 
    }

    public string Description { get; set; } = string.Empty;

    public virtual string BarriersForChipIn(Character character)
    {
        return string.Empty;
    }
}
