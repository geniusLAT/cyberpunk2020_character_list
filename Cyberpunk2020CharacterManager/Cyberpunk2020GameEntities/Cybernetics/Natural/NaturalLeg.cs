﻿namespace Cyberpunk2020GameEntities.Cybernetics.Natural;

public class NaturalLeg: BodyPart, ILeg
{
    public override bool IsImplant => false;

    public override string Name { get { return "биологическая нога"; } }
}
