namespace Cyberpunk2020GameEntities.Cybernetics.CybeweaponsBuiltInCyberLimb;

public class PopupGun : CybeweaponBuiltInCyberLimb
{
    public override string Name { get { return "Выпрыгивающее Оружие"; } }

    public PopupGun()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = "это стандартный автоматический пистолет, " +
            "скрытый B кибер-руке. Механизм монтируется во " +
            "всплывающем корпусе, который скрыт, когда он не используется." +
            " По этой причине ты всегда должен помнить, что нужно раскрывать " +
            "руку при использовании всплывающего оружия. Магазины вставлятся " +
            "в механизм сбоку, всплывающее оружие разработано для использования" +
            " исключительно с безгильзовыми боеприпасами. Размер кибер-руки " +
            "(зависящий от Телосложения) ограничивает размер оружия, которое " +
            "может быть установлено (аналогично Потайной кобуре). Примечание: " +
            "ты можешь установить любой пистолет соответствующего размера, " +
            "указанно B разделе Экипировка. Для выпрыгивающего оружия Лёгкий " +
            "ПП равен Тяжёлому Пистолету.";
        HumanityLossFormula = "2D6";
        Cost = 2;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = random.Next(1, 7) + random.Next(1, 7);
    }
}
