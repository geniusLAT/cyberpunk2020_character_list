namespace Cyberpunk2020GameEntities.Cybernetics;

public class ArmSlot : BodyPart
{
    public bool IsLeft { get; set; }

    public override bool IsImplant => false;

    public bool IsAdditional => false;

    public override string Name { get 
        { 
            return IsLeft ? "слот левой руки" : "слот правой руки"; 
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
