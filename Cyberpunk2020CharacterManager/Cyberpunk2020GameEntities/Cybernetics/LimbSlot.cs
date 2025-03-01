namespace Cyberpunk2020GameEntities.Cybernetics;

public abstract class LimbSlot : BodyPart
{
    public bool IsLeft { get; set; }

    public override bool IsImplant => false;

    public bool HasQuickMount { get; set; }

    public void CalculateHumanityLoss(Character character)
    {
        if (!HasQuickMount)
        {
            return;
        }

        var result = 0f;
        List<float> humanityLossesOfEachLimb = [];
        var children = character.GetChildBodyParts(Guid);
        foreach (var child in children)
        {
            child.IsQuickMounted = true;
            var humanityLossOfThatChild = child.HumanityLoss;
            var grandChildren = character.GetChildBodyParts(child.Guid);

            foreach (var grandChild in grandChildren)
            {
                child.IsQuickMounted = true;
                humanityLossOfThatChild += grandChild.HumanityLoss;
            }
            result += humanityLossOfThatChild;
        }
        var average = result / children.Count;
        HumanityLoss = average * 2;
    }
}
