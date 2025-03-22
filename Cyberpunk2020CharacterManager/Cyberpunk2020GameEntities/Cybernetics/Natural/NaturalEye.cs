using Cyberpunk2020GameEntities.Cybernetics.CyberOptics;

namespace Cyberpunk2020GameEntities.Cybernetics.Natural;

public class NaturalEye : BodyPart, Eye
{
    public override string Name { get { return "биологический глаз"; } }

    public override bool IsImplant => false;
}
