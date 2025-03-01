namespace Cyberpunk2020GameEntities.Cybernetics;

public class LegSlot : LimbSlot
{
    public override string Name
    {
        get
        {
            var noteAboutSide = IsLeft ? "левой" : "правой";
            var noteAboutQuickMount = HasQuickMount ? "быстросменный " : "";
            return $"{noteAboutQuickMount}слот {noteAboutSide} ноги";
        }
    }

    public LegSlot(bool isLeft)
    {
        IsLeft = isLeft;
    }

    public LegSlot()
    {

    }
}
