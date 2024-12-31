﻿namespace Cyberpunk2020GameEntities.Cybernetics;

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

    protected string UniquenessPotentialProblem(Character character) 
    {
        var AlreadyChippedIn = false;
        foreach (var part in character.BodyParts)
        {
            if (this.GetType() == part.GetType())
            {

                return $"{Name} не может быть имлантирован в двух экземплярах";
            }
        }
        return string.Empty;
    }
}
