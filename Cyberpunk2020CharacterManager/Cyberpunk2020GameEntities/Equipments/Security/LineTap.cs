namespace Cyberpunk2020GameEntities.Equipments.Security;

public class LineTap : Equipment
{
    public override string Name { get { return "Перехватчик линии"; } }

    public override int BookIndex { get; set; } = 3;

    public LineTap()
    {
        Description = " ";
        Cost = 200;
    }
}
