namespace Cyberpunk2020GameEntities.Cybernetics;

public class ArmSlot : LimbSlot
{
    public bool IsAdditional { get; set; }

    public override string Name { get 
        {
            var noteAboutAddition = IsAdditional ? "нижней" : string.Empty;
            var noteAboutSide = IsLeft ? "левой" : "правой";
            var noteAboutQuickMount = HasQuickMount ? "быстросменный " : "";
            return $"{noteAboutQuickMount}слот {noteAboutAddition} {noteAboutSide} руки";
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
