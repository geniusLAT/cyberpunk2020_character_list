namespace Cyberpunk2020GameEntities.Cybernetics.Cyberweapons;

public abstract class ImplantedFangs : Cyberweapon
{
    public override string BarriersForChipIn(Character character)
    {
        return FangUniquenessPotentialProblem(character);
    }

    protected string FangUniquenessPotentialProblem(Character character)
    {
        foreach (var part in character.BodyParts)
        {
            if (part is ImplantedFangs)
            {

                return $"Нельзя устанавливать более одного набора клыков\n";
            }
        }
        return string.Empty;
    }
}
