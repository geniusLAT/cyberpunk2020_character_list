namespace Cyberpunk2020GameEntities.Cybernetics;

public abstract class Cyberlimb :Implant
{
    public string namePrefix { get; set; }

    public int MaxStoppingPower { get; set; }

    public int CurrentStoppingPower { get; set; }

    public int MaxSdp { get; set; }

    public int FunctionSdpThreshold { get; set; }

    public int CurrentSdp { get; set; }
}
