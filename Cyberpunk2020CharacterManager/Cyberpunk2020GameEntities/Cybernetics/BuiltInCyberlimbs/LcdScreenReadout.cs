namespace Cyberpunk2020GameEntities.Cybernetics.BuiltInCyberlimbs;

public class LcdScreenReadout : BuiltInCyberlimb
{
    public override string Name { get { return "Считывающий ЖК-экран"; } }

    public LcdScreenReadout()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " это ТВ экран 5 на 10 см может выводить цветное " +
            "графическое изображение. Обычно он покрыт прозрачным защитным " +
            "экраном. Изображение может быть получено с Цифрового рекордера, " +
            "Мини видео и Мини камеры, а также кибер-оптики. Можно провести " +
            "кабель от AUX разъёма и подключить к любому стандартному " +
            "Интерфейсному разъёму передачи изображений чужой кибер-оптики" +
            " или рекордера.";
        HumanityLossFormula = "1";
        Cost = 200;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }
}
