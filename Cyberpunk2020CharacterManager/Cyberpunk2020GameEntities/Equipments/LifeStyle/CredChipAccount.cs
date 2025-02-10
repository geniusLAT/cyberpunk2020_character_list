namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class CredChipAccount : Equipment
{
    public override string Name { get { return "Учётная запись кредитного чипа за месяц"; } }

    public override int BookIndex { get; set; } = 4;

    public CredChipAccount()
    {
        Description = "";
        Cost = 20;
    }
}
