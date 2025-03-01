using System.Text;

namespace Cyberpunk2020GameEntities.Equipments.Armor;

public abstract class Armor : Equipment
{
    public bool IsSoft {  get; set; }

    public int MaxStoppingPower { get; set; }

    public int CurrentStoppingPower { get; set; }

    public int EncumberanceValue { get; set; }

    public ProtectedBodyPart[] protectedBodyParts { get; set; } = [];

    static string[] BodyPartName =
        [
        "Голова",
        "Торс",
        "Руки",
        "Ноги"
        ];

    public virtual string GenerateArmorCodeDescription()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.Append("Значение утяжеления: ");
        stringBuilder.Append(EncumberanceValue);
        stringBuilder.Append("\nSP (Stopping power: ");
        stringBuilder.Append(CurrentStoppingPower.ToString());
        stringBuilder.Append('/');
        stringBuilder.Append(MaxStoppingPower.ToString());
        stringBuilder.Append("\nПокрывает: ");
        for (int i = 0; i< protectedBodyParts.Length; i++)
        {
            if(i != 0)
            {
                stringBuilder.Append(", ");
            }
            stringBuilder.Append(BodyPartName[(int)protectedBodyParts[i]]);
        }

        return stringBuilder.ToString();
    }
}
