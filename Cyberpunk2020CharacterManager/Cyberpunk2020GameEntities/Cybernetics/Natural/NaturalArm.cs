namespace Cyberpunk2020GameEntities.Cybernetics.Natural;

public class NaturalArm : BodyPart, IArm
{
    public override bool IsImplant => false;

    public override string Name { get { return "биологическая рука"; } }

}
