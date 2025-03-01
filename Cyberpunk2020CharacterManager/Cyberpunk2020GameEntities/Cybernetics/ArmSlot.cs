namespace Cyberpunk2020GameEntities.Cybernetics;

public class ArmSlot : BodyPart
{
    public bool IsLeft { get; set; }

    public override bool IsImplant => false;

    public bool IsAdditional;

    public override string Name { get 
        {
            var noteAboutAddition = IsAdditional ? "нижней" : string.Empty;
            return IsLeft ? $"слот {noteAboutAddition} левой руки" : $"слот {noteAboutAddition} правой руки";
        }
    }

    public ArmSlot(bool isLeft) 
    {
        IsLeft = isLeft;
    }

    public ArmSlot()
    {
       
    }
}
