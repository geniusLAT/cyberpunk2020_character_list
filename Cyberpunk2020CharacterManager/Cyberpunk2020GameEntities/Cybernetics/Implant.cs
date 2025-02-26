namespace Cyberpunk2020GameEntities.Cybernetics;

public abstract class Implant : BodyPart
{
    public SurgeryCode SurgeryCode { get; set; }

    public string HumanityLossFormula { get; set; } = "0";

    public virtual void GenerateHumanLoss(Random random) { HumanityLoss = 0; }

    public int OptionsAlloweded { get; set; }

    public override bool IsImplant 
    { 
        get {
            return true;
        } 
    }

    public string Description { get; set; } = string.Empty;

    public virtual string BarriersForChipIn(Character character)
    {
        return string.Empty;
    }

    protected string UniquenessPotentialProblem(Character character) 
    {
        foreach (var part in character.BodyParts)
        {
            if (this.GetType() == part.GetType())
            {

                return $"{Name} не может быть имлантирован в двух экземплярах\n";
            }
        }
        return string.Empty;
    }

    public virtual void ChipIn(Character character, Random random)
    {
        character.BodyParts.Add(this);
        character.CurrentMoney -=Cost;
        GenerateHumanLoss(random);
        character.totalHumanityLoss +=HumanityLoss;
    }
}
