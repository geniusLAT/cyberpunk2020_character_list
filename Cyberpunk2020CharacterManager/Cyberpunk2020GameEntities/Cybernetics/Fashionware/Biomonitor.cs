namespace Cyberpunk2020GameEntities.Cybernetics.Fashionware;

public class Biomonitor : Implant
{
    public override string Name { get { return "Биомонитор"; } }

    public Biomonitor()
    {
        SurgeryCode = SurgeryCode.Negligible;
        Description = " это фаворит Соло, фанатов гаджетов и взволнованных Корпоратов," +
            " обеспокоенных их кровяным давление. Установленный под кожу предплечья " +
            "Биомонитор постоянно замеряет показатели сердцебиения, дыхания, мозговых " +
            "волн, уровня сахара в крови, температуры и уровня холестерина. Дисплей " +
            "представляет собой узор из светодиодов в форме слов каждый из которых имеет" +
            " цветовую последовательность от красного (критический) до зелёного (отличный)." +
            " По мере изменения показаний цвет меняется. Пользователь просто откидывает" +
            " назад свою манжету, находит нужное ему светящееся слово и смотрит на цвет. " +
            "С точки зрения игры, это добавляет +2 к любой проверке Сопротивлениz пыткам/ наркотикам.";
        HumanityLossFormula = "1";
        Cost = 100;
    }

    public override void GenerateHumanLoss(Random random)
    {
        HumanityLoss = 1;
    }

    public override string BarriersForChipIn(Character character)
    {
        return string.Empty;
    }
}
