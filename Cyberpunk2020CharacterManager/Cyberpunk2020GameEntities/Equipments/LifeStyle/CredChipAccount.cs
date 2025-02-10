namespace Cyberpunk2020GameEntities.Equipments.LifeStyle;

public class CredChipAccount : Equipment
{
    public override string Name { get { return "Учётная запись кредитного чипа за месяц"; } }

    public override int BookIndex { get; set; } = 4;

    public CredChipAccount()
    {
        Description = " \"дебетовая карта\", которую ты используешь для переноса наличных денег заместо кошелька.";
        Cost = 20;
    }
}
