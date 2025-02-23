namespace Cyberpunk2020GameEntities.Equipments.Security;

public class CodeDecryptor : Equipment
{
    public override string Name { get { return "Дешифратор кода"; } }

    public override int BookIndex { get; set; } = 4;

    public CodeDecryptor()
    {
        Description = "зонд этого устройства вставляется в замок автомобиля вместо обычной карты. " +
            "Использование дешифратора добавляет +5 к проверке твоего базового навыка " +
            "обхода блокировок ТЕХ + Электронная безопасность + 1D10. ";
        Cost = 500;
    }
}
