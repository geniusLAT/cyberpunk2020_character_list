namespace Cyberpunk2020GameEntities.Cybernetics.Natural;

public class NaturalArm : NaturalLimb, IArm
{
    public string NamePrefix { get; set; }

    public override string Name { get { return NamePrefix + "биологическая рука"; } }

}
