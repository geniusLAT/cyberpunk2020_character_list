using Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;
using Cyberpunk2020GameEntities.Cybernetics.Natural;

namespace Cyberpunk2020GameEntities.Cybernetics;

public abstract class Cyberlimb :Implant
{
    public string namePrefix { get; set; }

    public int MaxStoppingPower { get; set; }

    public int CurrentStoppingPower { get; set; }

    public int MaxSdp { get; set; }

    public int FunctionSdpThreshold { get; set; }

    public int CurrentSdp { get; set; }

    public override void ChipIn(Character character, Random random)
    {
        var isQuickMountNeeded = false;
        var otherLimbs = character.GetChildBodyParts(BodyPlace);
        if (otherLimbs.Any())
        {
            if (otherLimbs.First() is NaturalLimb)
            {
                character.BodyParts.Remove(otherLimbs.First());
            }
            else
            {
                IsQuickMounted = true;
                isQuickMountNeeded = true;
            }
        }

        var slot = character.GetBodyPart(BodyPlace);
        if (slot == null) { throw new Exception("lost parent"); }

        var limbSlot = (LimbSlot)slot;
        if (limbSlot.IsLeft)
        {
            namePrefix = "Левая ";
        }
        else
        {
            namePrefix = "Правая ";
        }

        if (limbSlot is ArmSlot)
        {
            if (((ArmSlot)limbSlot).IsAdditional)
            {
                namePrefix += "нижняя ";
            }
        }

        base.ChipIn(character, random);

        if (isQuickMountNeeded)
        {
            var quickMount = new QuickChangeMount();
            quickMount.IsQuickMounted = true;
            quickMount.BodyPlace = Guid;
            quickMount.ChipIn(character, random);
        }
    }
}
