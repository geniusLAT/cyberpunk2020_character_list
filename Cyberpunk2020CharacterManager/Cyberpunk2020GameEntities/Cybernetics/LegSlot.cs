﻿namespace Cyberpunk2020GameEntities.Cybernetics;

public class LegSlot : BodyPart
{
    public bool IsLeft;
    public override bool IsImplant => false;

    public override string Name
    {
        get
        {
            return IsLeft ? "слот левой ноги" : "слот правой ноги";
        }
    }

    LegSlot(bool isLeft)
    {
        IsLeft = isLeft;
    }

    LegSlot()
    {

    }
}