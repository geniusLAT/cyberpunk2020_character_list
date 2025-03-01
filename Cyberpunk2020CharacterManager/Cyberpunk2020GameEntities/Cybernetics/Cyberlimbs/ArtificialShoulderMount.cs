using System.Text;

namespace Cyberpunk2020GameEntities.Cybernetics.Cyberlimbs;

public class ArtificialShoulderMount : Implant
{
    public override string Name { get { return namePrefix + "Искусственные плечи"; } }

    public string namePrefix { get; set; }

    public int MaxStoppingPower { get; set; }

    public int CurrentStoppingPower { get; set; }

    public int MaxSdp { get; set; }

    public int FunctionSdpThreshold { get; set; }

    public int CurrentSdp {  get; set; }

    public ArtificialShoulderMount()
    {
        SurgeryCode = SurgeryCode.Critical;
        Description = "это шарнирные соединения, которые можно прикрепить к наспинной раме." +
            " Это позволяет установить до двух дополнительных рук на уровне талии. Блок имеет 25 SDP.";
        HumanityLossFormula = "2D6";
        Cost = 1500;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }

    public override string BarriersForChipIn(Character character)
    {
        return UniquenessPotentialProblem(character);
    }

    public override void ChipIn(Character character, Random random)
    {
        base.ChipIn(character, random);

        var leftArtificialArmSlot = new ArmSlot();
        var rightArtificialArmSlot = new ArmSlot();

        leftArtificialArmSlot.IsLeft = true;
        rightArtificialArmSlot.IsLeft = false;

        leftArtificialArmSlot.IsAdditional = rightArtificialArmSlot.IsAdditional = true;
        leftArtificialArmSlot.BodyPlace = rightArtificialArmSlot.BodyPlace = Guid;

        character.BodyParts.Add(leftArtificialArmSlot);
        character.BodyParts.Add(rightArtificialArmSlot);
    }
}
