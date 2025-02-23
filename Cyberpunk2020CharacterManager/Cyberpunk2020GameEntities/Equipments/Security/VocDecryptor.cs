namespace Cyberpunk2020GameEntities.Equipments.Security;

public class VocDecryptor : Equipment
{
    public override string Name { get { return "Дешифратор голоса"; } }

    public override int BookIndex { get; set; } = 5;

    public VocDecryptor()
    {
        Description = "модулятор голоса для взлома голосовых блокировок. " +
            "Использование дешифратора добавляет +5 к проверке твоего базового навыка " +
            "обхода блокировок ТЕХ + Электронная безопасность + 1D10. ";
        Cost = 1000;
    }
}
